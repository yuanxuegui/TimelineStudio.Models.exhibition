﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimelineStudio.Models.exhibition.Util;

namespace TimelineStudio.Models.exhibition.Domain
{
    public class CommandContext : ICommandContext
    {
        private ITimelineContext timelineContextField;

        public ITimelineContext TimelineContext
        {
            get { return timelineContextField; }
            set { timelineContextField = value; }
        }

        public CommandContext(ITimelineContext timelineContext)
        {
            timelineContextField = timelineContext;
        }

        public string BuildCommand(Command command)
        {
            string deviceId = command.DeviceId;
            string operationName = command.OperationName;
            Device device = timelineContextField.GetArea().GetItemByKey(deviceId);
            Operation operation = device.GetItemByKey(operationName);
            string commandContent = operation.Command;
            commandContent = commandContent.Replace("{" + Constants.CMD_DEVICE_ID +  "}", device.Id);
            foreach (Parameter parameter in operation.ParameterItems)
            {
                string name = parameter.Name;
                string value = command.GetPropertyValue(name);
                if (name != null && value != null)
                    commandContent = commandContent.Replace("{" + name + "}", value);
            }
            return commandContent;
        }
    }
}
