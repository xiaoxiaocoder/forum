﻿using System;
using ENode.Commanding;
using ENode.Infrastructure;

namespace Forum.Commands.Sections
{
    [Code(17)]
    public class CreateSectionCommand : Command
    {
        public string Name { get; set; }

        private CreateSectionCommand() { }
        public CreateSectionCommand(string id, string name) : base(id)
        {
            Name = name;
        }
    }
}
