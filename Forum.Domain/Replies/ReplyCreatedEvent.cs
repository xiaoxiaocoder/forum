﻿using System;
using ENode.Eventing;
using ENode.Infrastructure;

namespace Forum.Domain.Replies
{
    /// <summary>表示回复已创建的领域事件
    /// </summary>
    [Code(14)]
    public class ReplyCreatedEvent : DomainEvent<string>
    {
        public string PostId { get; private set; }
        public string ParentId { get; private set; }
        public string AuthorId { get; private set; }
        public string Body { get; private set; }

        private ReplyCreatedEvent() { }
        public ReplyCreatedEvent(Reply reply, string postId, string parentId, string authorId, string body)
            : base(reply)
        {
            PostId = postId;
            ParentId = parentId;
            AuthorId = authorId;
            Body = body;
        }
    }
}