using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
using Blog.Entity.Enums;
using Blog.Service.Extensions;
using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Helpers.Images;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Blog.Service.Services.Concretes
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IImageHelper _imageHelper;
        private readonly ClaimsPrincipal _user;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _imageHelper = imageHelper;
            _user = _httpContextAccessor.HttpContext.User;
        }

        public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
        {
            var userId = _user.GetLoggedInUserId();
            var userEmail = _user.GetLoggedInUserEmail();

            var imageUpload = await _imageHelper.Upload(articleAddDto.Title, articleAddDto.Photo, ImageType.Post);
            Image image = new Image(imageUpload.FullName, articleAddDto.Photo.ContentType, userEmail);
            await _unitOfWork.GetRepository<Image>().AddAsync(image);

            var article = new Article(articleAddDto.Title, articleAddDto.Content, userId, userEmail, articleAddDto.CategoryId, image.Id);

            await _unitOfWork.GetRepository<Article>().AddAsync(article);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync(a => !a.IsDeleted, a => a.Category);
            var map = _mapper.Map<List<ArticleDto>>(articles);

            return map;
        }

        public async Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetAsync(a => !a.IsDeleted && a.Id == articleId, a => a.Category, i => i.Image);
            var map = _mapper.Map<ArticleDto>(article);

            return map;
        }

        public async Task<string> UpdateArticleAsync(ArticleUpdateDto articleUpdateDto)
        {
            var userEmail = _user.GetLoggedInUserEmail();
            var articleToUpdate = await _unitOfWork.GetRepository<Article>().GetAsync(a => !a.IsDeleted && a.Id == articleUpdateDto.Id, a => a.Category, i => i.Image);
            var articletitleBeforeUpdate = articleToUpdate.Title;

            if (articleUpdateDto.Photo != null)
            {
                _imageHelper.Delete(articleToUpdate.Image.FileName);

                var imageUpload = await _imageHelper.Upload(articleUpdateDto.Title, articleUpdateDto.Photo, ImageType.Post);
                Image image = new Image(imageUpload.FullName, articleUpdateDto.Photo.ContentType, userEmail);
                await _unitOfWork.GetRepository<Image>().AddAsync(image);

                articleToUpdate.ImageId = image.Id;
            }

            articleToUpdate.Title = articleUpdateDto.Title;
            articleToUpdate.Content = articleUpdateDto.Content;
            articleToUpdate.CategoryId = articleUpdateDto.CategoryId;
            articleToUpdate.ModifiedDate = DateTime.Now;
            articleToUpdate.ModifiedBy = userEmail;

            //_mapper.Map(articleToUpdate, articleUpdateDto);

            await _unitOfWork.GetRepository<Article>().UpdateAsync(articleToUpdate);
            await _unitOfWork.SaveAsync();
            return articletitleBeforeUpdate;
        }

        public async Task<string> SafeDeleteArticleAsync(Guid articleId)
        {
            var userEmail = _user.GetLoggedInUserEmail();
            var article = await _unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId);

            article.IsDeleted = true;
            article.DeletedDate = DateTime.Now;
            article.DeletedBy = userEmail;

            await _unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await _unitOfWork.SaveAsync();

            return article.Title;
        }
    }
}
