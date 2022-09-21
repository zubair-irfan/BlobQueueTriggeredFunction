// <copyright file="Constants.cs" company="WordSynk Ltd">
// Copyright (c) WordSynk Ltd. All rights reserved.
// </copyright>

namespace FunctionApp1
{
    /// <summary>
    /// Defines constants used to configure the subscriber services for dependency injection.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// The subscription name used on event bus topics.
        /// </summary>
        public const string SubscriptionName = "WordSynk.Offer.Functions.EventHandler";

        /// <summary>
        /// The subscription name used on event bus topics.
        /// </summary>
        public const string SourcingSubscriptionName = "WordSynk.Offer.Functions.SourcingEventsHandler";

        /// <summary>
        /// The booking topic name.
        /// </summary>
        public const string QueueName = "booking";

        /// <summary>
        /// The booking topic name.
        /// </summary>
        public const string SourcingTopic = "sourcing";

        /// <summary>
        /// The booking service bus connection string name.
        /// </summary>
        public const string BookingServiceBusConnectionStringName = "sb-booking";

        /// <summary>
        /// The sourcing service bus connection string name.
        /// </summary>
        public const string SourcingServiceBusConnectionStringName = "sb-sourcing";

        /// <summary>
        /// Gets the tenancy provider config key.
        /// </summary>
        public static string TenancyProviderKey => "OfferTenancyProvider";
    }
}
