<%@ WebHandler Language="C#" Class="Users_GetListByLoginName" %>

using System;
using System.Web;
using Model;
using BLL;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
public class Users_GetListByLoginName : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string username = context.Request.Params["userName"];
        UsersPersonInfo model = new UserManager().User_GetListByLoginName(username);
        DataContractJsonSerializer  ds = new DataContractJsonSerializer (typeof(UsersPersonInfo));
        ds.WriteObject(context.Response.OutputStream, model);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}