using Serilog.Sinks.Loki.Labels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Equinox.Infra.CrossCutting.Logger
{
    public class LogLabelProvider : ILogLabelProvider
    {

        public IList<LokiLabel> GetLabels()
        {
            return new List<LokiLabel>
            {
                new LokiLabel(key:"app",value:"equinox"),
                new LokiLabel(key:"environment",value:"production")
            };
        }

    }
}
