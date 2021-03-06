/*
 * Copyright (c) 2003-2020 by AG-Software <info@ag-software.de>
 *
 * All Rights Reserved.
 * See the COPYING file for more information.
 *
 * This file is part of the MatriX project.
 *
 * NOTICE: All information contained herein is, and remains the property
 * of AG-Software and its suppliers, if any.
 * The intellectual and technical concepts contained herein are proprietary
 * to AG-Software and its suppliers and may be covered by German and Foreign Patents,
 * patents in process, and are protected by trade secret or copyright law.
 *
 * Dissemination of this information or reproduction of this material
 * is strictly forbidden unless prior written permission is obtained
 * from AG-Software.
 *
 * Contact information for AG-Software is available at http://www.ag-software.de
 */

using Matrix.Xml;
using Matrix.Xmpp.PubSub;

namespace Matrix.Xmpp.Base
{
    public abstract class Subscription : XmppXElement
    {
        protected Subscription(string ns) : base(ns, "subscription")
        {
        }

        /// <summary>
        /// Gets or sets the jid.
        /// </summary>
        /// <value>The jid.</value>
        public Jid Jid
        {
            get { return GetAttributeJid("jid"); }
            set { SetAttribute("jid", value); }
        }

        /// <summary>
        /// Gets or sets the subscription id.
        /// </summary>
        /// <value>The subscription id.</value>
        public string Id
        {
            get { return GetAttribute("subid"); }
            set { SetAttribute("subid", value); }
        }

        /// <summary>
        /// Gets or sets the state of the subscription state.
        /// </summary>
        /// <value>The state of the subscription.</value>
        public SubscriptionState SubscriptionState
        {
            get { return GetAttributeEnum<SubscriptionState>("subscription"); }
            set { SetAttribute("subscription", value.ToString().ToLower()); }
        }
    }
}
