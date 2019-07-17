using System;
using System.ServiceModel;

namespace ServiceModelDiscrepancy.Library
{
    public interface IAttachable
    {
        void Attach(OperationContext context);
        void Detach(OperationContext context);
    }
}
