﻿using System.Threading.Tasks;
using ECommon.Components;
using ECommon.IO;
using ENode.Commanding;
using ENode.Infrastructure;
using Forum.Commands.Posts;
using Forum.Domain.Replies;

namespace Forum.ProcessManagers
{
    [Component]
    [Code(101)]
    public class CreateReplyProcessManager : IMessageHandler<ReplyCreatedEvent>
    {
        private ICommandService _commandService;

        public CreateReplyProcessManager(ICommandService commandService)
        {
            _commandService = commandService;
        }

        public Task<AsyncTaskResult> HandleAsync(ReplyCreatedEvent evnt)
        {
            return _commandService.SendAsync(new AcceptNewReplyCommand(evnt.PostId, evnt.AggregateRootId));
        }
    }
}
