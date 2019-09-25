﻿namespace pryNatillera.Filter.ActionFilter
{
    using Microsoft.AspNetCore.Mvc.Filters;
    using pryNatillera.Filter.ValidacionModelo;

    /// <summary>
    /// Defines the <see cref="ValidateModelAttribute" />
    /// </summary>
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// The OnActionExecuting
        /// </summary>
        /// <param name="context">The context<see cref="ActionExecutingContext"/></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new ValidationFailedResult(context.ModelState);
            }
        }
    }
}
