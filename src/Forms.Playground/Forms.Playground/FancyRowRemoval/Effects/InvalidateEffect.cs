using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Forms.Playground.FancyRowRemoval.Effects
{
    public class InvalidateEffect : RoutingEffect
    {
        public InvalidateEffect() : base($"Forms.Playground.{nameof(InvalidateEffect)}") { }
    }
}
