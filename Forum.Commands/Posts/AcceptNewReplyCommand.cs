﻿using System;
using ENode.Commanding;
using ENode.Infrastructure;

namespace Forum.Commands.Posts
{
    [Code(11)]
    public class AcceptNewReplyCommand : Command
    {
        public string ReplyId { get; private set; }

        private AcceptNewReplyCommand() { }
        public AcceptNewReplyCommand(string id, string replyId) : base(id)
        {
            ReplyId = replyId;
        }
    }
}
