<%@ WebHandler Language="C#" Class="Delete_OrdersByOrdernumber" %>

using System;
using System.Web;
using Model;
using BLL;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class Delete_OrdersByOrdernumber : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string Ordernumber = context.Request.Params["Ordernumber"];
        bool boo = new OrderManager().Delete(Ordernumber);
        DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(bool));
        ds.WriteObject(context.Response.OutputStream, boo);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}