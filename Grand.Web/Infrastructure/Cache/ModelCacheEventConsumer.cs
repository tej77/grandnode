﻿using Grand.Core.Caching;
using Grand.Core.Domain.Blogs;
using Grand.Core.Domain.Catalog;
using Grand.Core.Domain.News;
using Grand.Core.Domain.Orders;
using Grand.Core.Domain.Polls;
using Grand.Core.Domain.Topics;
using Grand.Core.Domain.Vendors;
using Grand.Core.Events;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Grand.Web.Infrastructure.Cache
{
    /// <summary>
    /// Model cache event consumer (used for caching of presentation layer models)
    /// </summary>
    public partial class ModelCacheEventConsumer :
        
        //templates
        INotificationHandler<EntityInserted<CategoryTemplate>>,
        INotificationHandler<EntityUpdated<CategoryTemplate>>,
        INotificationHandler<EntityDeleted<CategoryTemplate>>,
        INotificationHandler<EntityInserted<ManufacturerTemplate>>,
        INotificationHandler<EntityUpdated<ManufacturerTemplate>>,
        INotificationHandler<EntityDeleted<ManufacturerTemplate>>,
        INotificationHandler<EntityInserted<ProductTemplate>>,
        INotificationHandler<EntityUpdated<ProductTemplate>>,
        INotificationHandler<EntityDeleted<ProductTemplate>>,
        INotificationHandler<EntityInserted<TopicTemplate>>,
        INotificationHandler<EntityUpdated<TopicTemplate>>,
        INotificationHandler<EntityDeleted<TopicTemplate>>
        
        
    {


        private readonly ICacheManager _cacheManager;

        public ModelCacheEventConsumer(ICacheManager cacheManager)
        {
            _cacheManager = cacheManager;
        }



        //templates
        public async Task Handle(EntityInserted<CategoryTemplate> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheManager.RemoveByPrefix(ModelCacheEventConst.CATEGORY_TEMPLATE_PATTERN_KEY);
        }
        public async Task Handle(EntityUpdated<CategoryTemplate> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheManager.RemoveByPrefix(ModelCacheEventConst.CATEGORY_TEMPLATE_PATTERN_KEY);
        }
        public async Task Handle(EntityDeleted<CategoryTemplate> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheManager.RemoveByPrefix(ModelCacheEventConst.CATEGORY_TEMPLATE_PATTERN_KEY);
        }
        public async Task Handle(EntityInserted<ManufacturerTemplate> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheManager.RemoveByPrefix(ModelCacheEventConst.MANUFACTURER_TEMPLATE_PATTERN_KEY);
        }
        public async Task Handle(EntityUpdated<ManufacturerTemplate> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheManager.RemoveByPrefix(ModelCacheEventConst.MANUFACTURER_TEMPLATE_PATTERN_KEY);
        }
        public async Task Handle(EntityDeleted<ManufacturerTemplate> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheManager.RemoveByPrefix(ModelCacheEventConst.MANUFACTURER_TEMPLATE_PATTERN_KEY);
        }
        public async Task Handle(EntityInserted<ProductTemplate> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheManager.RemoveByPrefix(ModelCacheEventConst.PRODUCT_TEMPLATE_PATTERN_KEY);
        }
        public async Task Handle(EntityUpdated<ProductTemplate> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheManager.RemoveByPrefix(ModelCacheEventConst.PRODUCT_TEMPLATE_PATTERN_KEY);
        }
        public async Task Handle(EntityDeleted<ProductTemplate> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheManager.RemoveByPrefix(ModelCacheEventConst.PRODUCT_TEMPLATE_PATTERN_KEY);
        }
        public async Task Handle(EntityInserted<TopicTemplate> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheManager.RemoveByPrefix(ModelCacheEventConst.TOPIC_TEMPLATE_PATTERN_KEY);
        }
        public async Task Handle(EntityUpdated<TopicTemplate> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheManager.RemoveByPrefix(ModelCacheEventConst.TOPIC_TEMPLATE_PATTERN_KEY);
        }
        public async Task Handle(EntityDeleted<TopicTemplate> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheManager.RemoveByPrefix(ModelCacheEventConst.TOPIC_TEMPLATE_PATTERN_KEY);
        }


    }
}
