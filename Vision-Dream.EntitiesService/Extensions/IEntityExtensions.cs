#region Proprietary Information
/* 
    * Created by:   Vision-Dream ICT Solutions
    * Author:       Onkgopotse Lenake
    * Email:        visiondreamict@gmail.com
    * Website:      www.visiondreamict.wordpress.com
    * 
    * Copyright (c) 2019 Vision-Dream ICT Solutions. All rights reserved.
    * ___________________________________________________________________
    * Project:      Vision-Dream .Net Core library, targeting .Net Core 2.1.
    *               Library is generic to cater for multiple solutions.
    * Version:      v1.0.0
    * File:         IEntityExtensions.cs
    * Date:         2019-01-10
    * Description:  This file contains the IEntityExtensions class. 
    *               Class execution code.
*/
#endregion

namespace Vision_Dream.EntitiesService.Extensions
{
    /// <summary>
    /// The static <see cref="IEntityExtensions"/>, extension class helps to check entities for two conditions: 
    ///     1. Check if the whole entity object is null <see cref="IsObjectNull"/> and 
    ///        assign it the value 'null', if the condition is true.
    ///     2. Check if the entity.ID property is empty <see cref="IsEmptyObject"/> and 
    ///        assign it the value 'Empty', if the condition is true.
    /// </summary>
    public static class IEntityExtensions
    {
        public static bool IsObjectNull(this IEntity entity)
        {
            return entity == null;
        }

        public static bool IsEmptyObject(this IEntity entity)
        {
            return entity.EntityIDRel.Equals(0);
        }
    }
}
