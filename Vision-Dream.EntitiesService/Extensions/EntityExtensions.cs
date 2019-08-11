#region Proprietary Information
/* 
    * Created by:   Vision-Dream ICT Solutions
    * Author:       Onkgopotse Lenake
    * Email:        visiondreamict@gmail.com
    * Website:      www.visiondreamict.wordpress.com
    * 
    *               (c) 2019 Vision-Dream ICT Solutions. All rights reserved.
    * _______________________________________________________________________
    * Project:      Vision-Dream .Net Core library, targeting .Net Core 2.2.
    *               Library is generic to cater for multiple solutions.
    * Version:      v1.0.0
    * File:         EntityExtensions.cs
    * Date:         2019-01-10
    * Description:  This file contains the EntityExtensions class. 
    *               Class execution code.
*/
#endregion

namespace Vision_Dream.EntitiesService.Extensions
{
    /// <summary>
    /// Static <see cref="EntityExtensions"/> class helps to check entities for two conditions: 
    ///     1. Check if the whole entity object is null <see cref="IsObjectNull"/> and 
    ///        assign it the value 'null', if the condition is true.
    ///     2. Check if the entity.EntityID property is empty/zero <see cref="IsObjectEmpty"/> and 
    ///        assign it the value '0', if the condition is true.
    /// </summary>
    public static class EntityExtensions
    {
        public static bool IsObjectNull(this IEntity entity)
        {
            return entity == null;
        }

        public static bool IsObjectEmpty(this IEntity entity)
        {
            return entity.EntityID.Equals(0);
        }
    }
}
