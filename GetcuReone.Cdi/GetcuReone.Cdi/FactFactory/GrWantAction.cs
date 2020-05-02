using GetcuReone.FactFactory.Interfaces;
using GetcuReone.FactFactory.Versioned;
using GetcuReone.FactFactory.Versioned.BaseEntities;
using System;
using System.Collections.Generic;

namespace GetcuReone.Cdi.FactFactory
{
    /// <summary>
    /// Want action.
    /// </summary>
    public class GrWantAction : VersionedWantActionBase<VersionedFactBase>
    {
        /// <summary>
        /// Action for logging.
        /// </summary>
        public Action<string> WriteLogAction { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="wantAction"></param>
        /// <param name="factTypes"></param>
        public GrWantAction(Action<IFactContainer<VersionedFactBase>> wantAction, IReadOnlyCollection<IFactType> factTypes) : base(wantAction, factTypes)
        {
        }

        /// <summary>
        /// Run action.
        /// </summary>
        /// <typeparam name="TFactContainer"></typeparam>
        /// <param name="container"></param>
        public override void Invoke<TFactContainer>(TFactContainer container)
        {
            base.Invoke(container);
            WriteLogAction?.Invoke($"FactFactory | WantAction.Invoke | {ToString()}\n");
        }
    }
}
