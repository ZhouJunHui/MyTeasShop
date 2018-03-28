<%@ WebHandler Language="C#" Class="Add_OrDetaId" %>

using System;
using System.Web;
using Model;
using BLL;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class Add_OrDetaId : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        OrderDetaileds ODads = new OrderDetaileds();
        ODads.OrId = Convert.ToInt32(context.Request.Params["OrId"]);
        string Tid = context.Request.Params["Tid"];
        string Number =context.Request.Params["Number"];
        string Price = context.Request.Params["Price"];
        var Tids = Tid.Split(',');
        var Numbers=Number.Split(',');
        var Prices=Price.Split(',');
        bool boo = true;
        for (int i = 0; i < Tids.Length; i++)
        {
            ODads.Tid =Convert.ToInt32(Tids[i]);
            ODads.Number = Convert.ToInt32(Numbers[i]);
            ODads.Price = Convert.ToDecimal(Prices[i]);
            if (!new OrderDetailedManager().Add_OrDetail(ODads))
                boo = false;
        }
        DataContractJsonSerializer ds = new DataContractJsonSerializer(boo.GetType());
        ds.WriteObject(context.Response.OutputStream, boo);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}