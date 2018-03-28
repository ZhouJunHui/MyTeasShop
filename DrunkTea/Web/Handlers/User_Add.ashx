<%@ WebHandler Language="C#" Class="User_Add" %>

using System;
using System.Web;
using BLL;
using Model;
using System.Runtime.Serialization.Json;
public class User_Add : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        UsersPersonInfo model = new UsersPersonInfo();
        model.LoginName = context.Request.Params["txtuserName"];
        model.Pwd = context.Request.Params["txtPwd1"];
        model.Phone = context.Request.Params["txtPhone"];
        if (new UserManager().User_Add(model))
        {
            context.Response.Redirect("~/Login.html");
        }


    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}