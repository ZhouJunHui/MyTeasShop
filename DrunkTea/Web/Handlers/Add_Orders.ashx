<%@ WebHandler Language="C#" Class="Add_OrdersAndOrDetaId" %>

using System;
using System.Web;
using Model;
using BLL;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class Add_OrdersAndOrDetaId : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        Orders ods = new Orders();
        ods.Uid =Convert.ToInt32(context.Request.Params["Uid"]);
        ods.Total = Convert.ToDecimal(context.Request.Params["Total"]);
        ods.RecId = Convert.ToInt32(context.Request.Params["RecId"]);
        string boo = new OrderManager().Add(ods);
        DataContractJsonSerializer ds = new DataContractJsonSerializer(boo.GetType());
        ds.WriteObject(context.Response.OutputStream, boo);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}