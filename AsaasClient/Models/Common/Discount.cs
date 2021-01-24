﻿using AsaasClient.Models.Common.Enums;
using Newtonsoft.Json;

namespace AsaasClient.Models.Common
{
    public class Discount
    {
        public decimal Value { get; set; }

        public int DueDateLimitDays { get; set; }

        public DiscountType Type { get; set; }
    }
}
