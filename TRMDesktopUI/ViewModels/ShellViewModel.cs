using Caliburn.Micro;
using System.Threading;
using System.Threading.Tasks;
using TRMDesktopUI.EventModels;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        private IEventAggregator _events;

        private SalesViewModel _salesVM;

        private SimpleContainer _container;

        // Constructor injection see Bootstrapper.cs
        public ShellViewModel(
            IEventAggregator events, 
            SalesViewModel salesVM,
            SimpleContainer container
            )
        {
            _events = events;
            _events.SubscribeOnUIThread(this);

            _salesVM = salesVM;

            _container = container;

            ActivateItemAsync(_container.GetInstance<LoginViewModel>());
        }

        public Task HandleAsync(LogOnEvent message, CancellationToken cancellationToken)
        {
            return ActivateItemAsync(_salesVM);
        }
    }
}
