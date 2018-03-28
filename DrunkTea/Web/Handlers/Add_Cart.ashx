<%@ WebHandler Language="C#" Class="Add_Cart" %>

using System;
using System.Web;
using BLL;
using Model;
using System.Runtime.Serialization.Json;
public class Add_Cart : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        Cart cart = new Cart();
        cart.Uid =Convert.ToInt32(context.Request.Params["Uid"]);
        cart.Tid =Convert.ToInt32(context.Request.Params["Tid"]);
        bool boo = new CartManager().Add(cart);
        DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(bool));
        ds.WriteObject(context.Response.OutputStream, true);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}