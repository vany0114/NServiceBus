namespace NServiceBus.Notifications
{
    using Config;
    using System.Security.Principal;
    using Installation.Environments;
    using Unicast.Queuing;

    public class NotifierQueueInstaller : IWantQueuesCreated<Windows>
    {
        public ICreateQueues Creator { get; set; }

        public void Create(WindowsIdentity identity)
        {
            if (ConfigureNotifications.NotificationsDisabled)
                return;

            Creator.CreateQueueIfNecessary(BusExtensions.NotificationAddress, identity.Name);
        }
    }
}