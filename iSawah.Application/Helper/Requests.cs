﻿using iSawah.Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Helper
{
	public class Requests
	{
		public static IActionResult Response(ControllerBase controller,
		ApiStatus statusCode, object dataValue, string msg)
		{
			var e = new ApiStatus(500);
			var _ = new
			{
				status = e.StatusCode,
				error = true,
				detail = "",
				message = e.StatusDescription,
				data = dataValue
			};

			if (statusCode.StatusCode != 200)
			{
				_ = new
				{
					status = statusCode.StatusCode,
					error = true,
					detail = msg,
					message = statusCode.StatusDescription,
					data = dataValue
				};
			}
			else
			{
				_ = new
				{
					status = statusCode.StatusCode,
					error = false,
					detail = msg,
					message = statusCode.StatusDescription,
					data = dataValue
				};
			}

			return controller.StatusCode(statusCode.StatusCode, _);
		}
	}
}
