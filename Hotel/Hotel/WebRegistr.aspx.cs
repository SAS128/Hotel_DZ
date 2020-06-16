﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;

namespace Hotel
{
    public partial class WebRegistr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GuestResponse rsvp = new GuestResponse();
                if (TryUpdateModel(rsvp, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    ResponseRepository.GetRepository().AddResponse(rsvp);

                }
            }
        }
    }
}