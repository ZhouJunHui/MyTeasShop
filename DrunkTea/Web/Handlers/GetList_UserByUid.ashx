<%@ WebHandler Language="C#" Class="GetList_UserByUid" %>

using System;
using System.Web;
using Model;
using BLL;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class GetList_UserByUid : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string Uid = context.Request.Params["Uid"];
        UsersPersonInfo model = new UserManager().GetList_ByUid(Uid);
        DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(UsersPersonInfo));
        ds.WriteObject(context.Response.OutputStream, model);


    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}