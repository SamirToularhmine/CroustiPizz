using Xamarin.Forms;

namespace CroustiPizz.Mobile.Extensions
{
    public class ListViewItemTappedBehavior : EventBehavior<ListView, ListViewItemTappedBehavior>
    {
        protected override void SubscribeEvent(ListView bindable)
        {
            bindable.ItemTapped += OnItemTapped;
        }

        protected override void UnsubscribeEvent(ListView bindable)
        {
            bindable.ItemTapped -= OnItemTapped;
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            TriggerCommand(e.Item);
        }
    }
}