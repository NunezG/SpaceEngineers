﻿using ProtoBuf;
using VRage.Entity;
using VRage.ObjectBuilders;

namespace Sandbox.Common.ObjectBuilders
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public abstract class MyObjectBuilder_ToolbarItem : MyObjectBuilder_Base
    {
        public virtual void Remap(IMyRemapHelper remapHelper)
        {
        }
    }
}
