﻿using Online_Mobile_Recharge.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Mobile_Recharge.DTO.Request
{
	public class UserPaymentInfoRequest
	{
		public int Id { get; set; }
		public int CardNumber { get; set; }
		public int PaymentMethodId { get; set; }
		public int UserId { get; set; }
	}
}
