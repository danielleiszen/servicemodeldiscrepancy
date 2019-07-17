using ServiceModelDiscrepancy.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModelDiscrepancy
{
    public class ServiceImplementation : IAttachable
    {
        void IAttachable.Attach(System.ServiceModel.OperationContext context)
        {

        }

        void IAttachable.Detach(System.ServiceModel.OperationContext context)
        {

        }
    }
}
