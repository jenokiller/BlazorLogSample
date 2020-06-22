using log4net;

namespace BlazorLogSample.Pages
{
    public partial class Counter
    {
        static ILog logger = LogManager.GetLogger(typeof(Counter));
        private int currentCount = 0;

        void IncrementCount()
        {
            logger.Debug("開発中のデバッグ／トレースに使用する");
            logger.Info("Info");
            logger.Warn("Warn");
            logger.Error("Error");
            logger.Fatal("Fatal");
            currentCount++;
        }
    }
}