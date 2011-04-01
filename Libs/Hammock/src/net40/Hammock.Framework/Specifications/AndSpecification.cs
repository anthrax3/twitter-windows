﻿namespace Hammock.Framework.Specifications
{
    public class AndSpecification<T> : CompositeSpecificationBase<T>
    {
        public AndSpecification(ISpecification<T> one, ISpecification<T> other) : base(one, other) {}

        public override bool IsSatisfiedBy(T instance)
        {
            return One.IsSatisfiedBy(instance) && Other.IsSatisfiedBy(instance);
        }
    }
}