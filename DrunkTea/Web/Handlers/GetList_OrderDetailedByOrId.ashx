<%@ WebHandler Language="C#" Class="GetList_OrderDetailedByOrId" %>

using System;
using System.Web;
using Model;
using BLL;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class GetList_OrderDetailedByOrId : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string OrId = context.Request.Params["OrId"];
        List<OrderDetaileds> lst = new OrderDetailedManager().GetList(OrId);
        DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(List<OrderDetaileds>));
        ds.WriteObject(context.Response.OutputStream, lst);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}