/*
 * Mundipagg
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

using System;

namespace Mundipagg.Models.Request
{
    public class CreateUsageRequest
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public string Mgroup { get; set; }

        public int Quantity { get; set; }

        public DateTime UsedAt { get; set; }
    }
}