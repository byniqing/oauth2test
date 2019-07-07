using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4;
using IdentityServer4.Test;
using IdentityServer4.Models;
using System.Security.Claims;

namespace AuthorizationServer
{
    public class Config
    {
        /// <summary>
        /// 用户的资源信息
        /// </summary>
        /// <returns></returns>
        public static List<IdentityResource> GetIdentityResource()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource{
                    Name="offline_access", //这样客户端才能收到refresh_token
                    DisplayName="离线访问",
                    Description="用于返回refresh_token",
                    //Required=true, //是否必须，如果为true ，则授权页面不能取消勾选
                    //Emphasize=true
                }
            };
        }
        /// <summary>
        /// 定义用户可以访问的资源
        /// </summary>
        /// <returns></returns>
        public static List<ApiResource> GetApiResources()
        {
            var oidc = new ApiResource
            {
                Name = "OAuth.ApiName", //这是资源名称
                Description = "2",
                DisplayName = "33",
                Scopes = {
                     new Scope{
                        Name="OtherInfo",
                        Description="描述",
                        DisplayName="获取你的其他信息",
                    },
                    new Scope{
                        Name="oidc1", //这里是指定客户端能使用的范围名称 , 是唯一的
                        Description="描述",
                        DisplayName="获得你的个人信息，好友关系",
                        Emphasize=true,
                        Required=true,
                        //ShowInDiscoveryDocument=true,
                    },
                    new Scope{
                        Name="oidc2",
                        Description="描述",
                        DisplayName="分享内容到你的博客",
                        Emphasize=true,
                        Required=true,
                    }
                }
            };
            return new List<ApiResource> {
                /*
                 具有单个作用域的简单API，这样定义的话，作用域（scope）和Api名称（ApiName）相同
                 */
                //new ApiResource("api","描述"),

                 //如果需要更多控制，则扩展版本
                //new ApiResource{
                //    Name="userinfo", //资源名称，对应客户端的：ApiName，必须是唯一的
                //    Description="描述",
                //    DisplayName="", //显示的名称
                  
                //    //ApiSecrets =
                //    //{
                //    //    new Secret("secret11".Sha256())
                //    //},

                //    //作用域，对应下面的Cliet的 AllowedScopes
                //    Scopes={
                //        new Scope
                //        {
                //            Name = "apiInfo.read_full",
                //            DisplayName = "完全的访问权限",
                //            UserClaims={ "super" }
                //        },
                //        new Scope
                //        {
                //            Name = "apiinfo.read_only",
                //            DisplayName = "只读权限"
                //        }
                //    },
                //},
                oidc
            };
        }
        /// <summary>
        /// 客户端合法性验证
        /// 在同意授权页面显示给用户看的
        /// </summary>
        /// <returns></returns>
        public static List<Client> GetClients()
        {
            var oidc = new Client
            {
                ClientId = "oidc",
                ClientName = "博客园",
                ClientSecrets = { new Secret("secret".Sha256()) },
                ClientUri = "http://www.cnblogs.com", //客户端
                LogoUri = "https://www.cnblogs.com/images/logo_small.gif",
                AllowedGrantTypes = { GrantType.AuthorizationCode },
                RequireConsent = false, //不现实授权页面
                /*
                 如果客户端使用的认证是
                 */
                //AllowedGrantTypes = GrantTypes.Hybrid,
                AllowedScopes ={
                    /*
                         Profile就是用户资料，ids 4里面定义了一个IProfileService的接口用来获取用户的一些信息，主要是为当前的认证上下文绑定claims。我们可以实现IProfileService从外部创建claim扩展到ids4里面。
                         */
                        IdentityServerConstants.StandardScopes.Profile,
                          /*
                         openid是必须要的。因为客户端接受的的是oidc
                         客户端会根据oidc和SubjectId获取用户信息，
                         所以：Profile也必须要，Profile 就是用户信息

                        如果没有Profile ，就没有办法确认身份
                         */
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Email,
                    //IdentityServerConstants.StandardScopes.OfflineAccess,
                    //"address",
                    "OtherInfo"
                    },

                //客户端默认传过来的是这个地址，如果跟这个不一直就会异常
                /*
                   授权成功后，返回地址
                   客户端哪里触发调用的地址，就会回调当前地址
                   比如：访问admin控制器未授权，调整授权服务器成功后，就会回调到admin页面
                 */
                RedirectUris = {
                    "http://192.168.1.102:5002/signin-oidc",
                   "http://192.168.1.102:5003/signin-oidc"
                },
                //注销后重定向的地址
                PostLogoutRedirectUris = {
                    "http://192.168.1.102:5002/signout-callback-oidc",
                    "http://192.168.1.102:5003/signout-callback-oidc"
                },
                AllowOfflineAccess = true, ////offline_access(开启refresh token)

                /*
                 这样就会把返回的profile信息包含在idtoken中
                 */
                AlwaysIncludeUserClaimsInIdToken = true,
                //AccessTokenLifetime token 过期时间
            };
            var oauth = new Client
            {
                ClientId = "OAuth.Client",
                ClientName = "博客园",
                ClientSecrets = { new Secret("secret".Sha256()) },
                //AllowedGrantTypes={GrantType.AuthorizationCode }
                AllowedGrantTypes = GrantTypes.Code,
                //RequireConsent=true,
                ClientUri = "http://www.cnblogs.com", //客户端
                LogoUri = "https://www.cnblogs.com/images/logo_small.gif",
                AllowedScopes ={
                        "OAuth1","OAuth2","OAuth3"
                    },

                /*
                 授权成功后，返回地地址
                 */
                RedirectUris = { "http://localhost:5002/OAuth" },
                //注销后重定向的地址
                PostLogoutRedirectUris = { "http://localhost:5002" },
                //RefreshTokenUsage= TokenUsage.ReUse
                //AllowOfflineAccess = true,
                //AllowAccessTokensViaBrowser = true
            };
            return new List<Client> {
               oidc,
               //oauth
           };
        }

        /// <summary>
        /// 用户名密码
        /// </summary>
        /// <returns></returns>
        public static List<TestUser> GetTestUsers()
        {
            return new List<TestUser> {
                new TestUser
                {
                    SubjectId="100000", //用户ID
                    Username="nsky", //用户名
                    Password="123", //密码
                    /*
                     * 这里的信息就是： IdentityServerConstants.StandardScopes.Profile
                     */
                    Claims=new List<Claim>{
                        new Claim("name","nsky"),
                        new Claim("email","cnblgos@sina.com"),
                        new Claim("website","http://www.cnblogs.com")
                    }
                }
            };
        }
    }
}
