namespace WorkChronicle.Controls.Popups
{
    public partial class CreatingPopup : Popup
    {
        private int dotCount = 0;
        private CancellationTokenSource? animationTokenSource;

        public CreatingPopup()
        {
            InitializeComponent();
            _ = StartDotAnimation();

        }

        public async Task StartDotAnimation()
        {
            this.animationTokenSource = new CancellationTokenSource();
            var token = this.animationTokenSource.Token;

            while (!token.IsCancellationRequested)
            {
                this.dotCount = (this.dotCount + 1) % 4;

                this.Dispatcher.Dispatch(() =>
                {
                    this.MessageLabel.Text = ControlAppResources.Creating + new string('.', dotCount);
                });

                await Task.Delay(500, token);
            }
        }

        protected override Task OnClosed(object? result, bool wasDismissedByTappingOutsideOfPopup, CancellationToken token = default)
        {
            this.animationTokenSource?.Cancel();

            return base.OnClosed(result, wasDismissedByTappingOutsideOfPopup, token);
        }

    }
}