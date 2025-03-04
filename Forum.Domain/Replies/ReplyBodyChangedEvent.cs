﻿using System;
using ENode.Eventing;
using ENode.Infrastructure;

namespace Forum.Domain.Replies
{
    /// <summary>表示回复内容已修改的领域事件
    /// </summary>
    [Code(15)]
    public class ReplyBodyChangedEvent : DomainEvent<string>
    {
        public string Body { get; private set; }

        private ReplyBodyChangedEvent() { }
        public ReplyBodyChangedEvent(Reply reply, string body) : base(reply)
        {
            Body = body;
        }
    }
}
