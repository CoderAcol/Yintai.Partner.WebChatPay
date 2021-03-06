﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yintai.Partner.WebChatPay.Dto.Response
{
    public class OrderQueryResponse : ResponseBase
    {
        public OrderQueryOrderInfo order_info { get; set; }
    }

    public class OrderQueryOrderInfo
    {
        public string ret_code { get; set; }
        public string ret_msg { get; set; }
        public string input_charset { get; set; }
        public string trade_state { get; set; }
        public string trade_mode { get; set; }
        public string partner { get; set; }
        public string bank_type { get; set; }
        public string bank_billno { get; set; }
        public string total_fee { get; set; }
        public string fee_type { get; set; }
        public string transaction_id { get; set; }
        public string out_trade_no { get; set; }
        public string is_split { get; set; }
        public string is_refund { get; set; }
        public string attach { get; set; }
        public string time_end { get; set; }
        public string transport_fee { get; set; }
        public string product_fee { get; set; }
        public string discount { get; set; }
        public string rmb_total_fee { get; set; }
    }
}
