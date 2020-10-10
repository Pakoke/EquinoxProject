namespace Equinox.Infra.CrossCutting.Logger
{
    public static class SerilogStringTemplates
    {
        public static string MiddlewareMessageTemplate = "ThreadId={ThreadId} InstanceId={instanceId} Method={RequestMethod} RequestPath={RequestPath} responded {StatusCode} in Elapse={Elapsed:0.0000} ms";

        public static string ValidationStaffMessageTemplate = "TypeValidator {Type} Dni {dni} message validator {message}";

        public static string LokiLabelDebug = "Information";

    }
}
