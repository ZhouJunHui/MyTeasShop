<%@ WebHandler Language="C#" Class="Users_PersonInfo_GetListByUid" %>

using System;
using System.Web;
using BLL;
using Model;
using System.Runtime.Serialization.Json;
public class Users_PersonInfo_GetListByUid : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string Uid = context.Request.Params["Uid"];
        UsersPersonInfo model = new UserManager().Users_PersonInfo_GetListByUid(Uid);
        DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(UsersPersonInfo));
        ds.WriteObject(context.Response.OutputStream, model);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}