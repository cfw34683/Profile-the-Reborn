using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clio.Utilities;
using Clio.XmlEngine;
using ff14bot.Behavior;
using ff14bot.Helpers;
using ff14bot.Managers;
using ff14bot.Navigation;
using ff14bot.NeoProfiles;
using ff14bot.RemoteWindows;
using TreeSharp;
using Action = TreeSharp.Action;

namespace ff14bot.NeoProfiles.Tags
{
    [XmlElement("ExtendedTalkTo")]

    class ExtendedTalkToTag : TalkToTag
    {
        protected override Composite CreateBehavior()
        {
            return new PrioritySelector(
                new Decorator(ret => QuestId == 66426 && SelectString.IsOpen,
                    new Action(r =>
                    {
                        SelectString.ClickSlot(2);
                    })
                ),
                base.CreateBehavior()
                );
        }
    }
}