﻿using ECommon.IoC;
using ENode.Commanding;
using Forum.Commands.Accounts;
using Forum.Domain.Accounts;

namespace Forum.CommandHandlers
{
    [Component]
    internal sealed class AccountCommandHandler : ICommandHandler<CreateAccountCommand>
    {
        public void Handle(ICommandContext context, CreateAccountCommand command)
        {
            context.Add(new Account(command.AggregateRootId, command.Name, command.Password));
        }
    }
}
