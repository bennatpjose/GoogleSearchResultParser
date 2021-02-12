// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

public class Url
{
    public string type { get; set; }
    public string template { get; set; }
}

public class Request
{
    public string title { get; set; }
    public string totalResults { get; set; }
    public string searchTerms { get; set; }
    public int count { get; set; }
    public int startIndex { get; set; }
    public string inputEncoding { get; set; }
    public string outputEncoding { get; set; }
    public string safe { get; set; }
    public string cx { get; set; }
}

public class NextPage
{
    public string title { get; set; }
    public string totalResults { get; set; }
    public string searchTerms { get; set; }
    public int count { get; set; }
    public int startIndex { get; set; }
    public string inputEncoding { get; set; }
    public string outputEncoding { get; set; }
    public string safe { get; set; }
    public string cx { get; set; }
}

public class Queries
{
    public List<Request> request { get; set; }
    public List<NextPage> nextPage { get; set; }
}

public class Context
{
    public string title { get; set; }
}

public class SearchInformation
{
    public double searchTime { get; set; }
    public string formattedSearchTime { get; set; }
    public string totalResults { get; set; }
    public string formattedTotalResults { get; set; }
}

public class CseThumbnail
{
    public string src { get; set; }
    public string width { get; set; }
    public string height { get; set; }
}

public class Imageobject
{
    public string width { get; set; }
    public string url { get; set; }
    public string height { get; set; }
    public string logo { get; set; }
}

public class Person
{
    public string name { get; set; }
}

public class Organization
{
    public string name { get; set; }
}

public class Metatag
{
    public string viewport { get; set; }
    [JsonProperty("msapplication-tileimage")]
    public string MsapplicationTileimage { get; set; }
    [JsonProperty("og:image")]
    public string OgImage { get; set; }
    [JsonProperty("apple-itunes-app")]
    public string AppleItunesApp { get; set; }
    [JsonProperty("theme-color")]
    public string ThemeColor { get; set; }
    [JsonProperty("twitter:title")]
    public string TwitterTitle { get; set; }
    [JsonProperty("al:ios:app_name")]
    public string AlIosAppName { get; set; }
    [JsonProperty("msvalidate.01")]
    public string Msvalidate01 { get; set; }
    [JsonProperty("og:title")]
    public string OgTitle { get; set; }
    [JsonProperty("al:android:package")]
    public string AlAndroidPackage { get; set; }
    [JsonProperty("fb:pages")]
    public string FbPages { get; set; }
    [JsonProperty("og:description")]
    public string OgDescription { get; set; }
    [JsonProperty("twitter:dnt")]
    public string TwitterDnt { get; set; }
    [JsonProperty("al:ios:app_store_id")]
    public string AlIosAppStoreId { get; set; }
    [JsonProperty("al:android:url")]
    public string AlAndroidUrl { get; set; }
    [JsonProperty("fb:app_id")]
    public string FbAppId { get; set; }
    [JsonProperty("oath:guce:consent-host")]
    public string OathGuceConsentHost { get; set; }
    [JsonProperty("twitter:site")]
    public string TwitterSite { get; set; }
    [JsonProperty("twitter:description")]
    public string TwitterDescription { get; set; }
    [JsonProperty("al:android:app_name")]
    public string AlAndroidAppName { get; set; }
    [JsonProperty("application-name")]
    public string ApplicationName { get; set; }
    [JsonProperty("og:type")]
    public string OgType { get; set; }
    [JsonProperty("og:image:width")]
    public string OgImageWidth { get; set; }
    [JsonProperty("twitter:card")]
    public string TwitterCard { get; set; }
    [JsonProperty("apple-mobile-web-app-title")]
    public string AppleMobileWebAppTitle { get; set; }
    [JsonProperty("og:image:height")]
    public string OgImageHeight { get; set; }
    [JsonProperty("twitter:image")]
    public string TwitterImage { get; set; }
    public string referrer { get; set; }
    [JsonProperty("apple-mobile-web-app-status-bar-style")]
    public string AppleMobileWebAppStatusBarStyle { get; set; }
    [JsonProperty("msapplication-tap-highlight")]
    public string MsapplicationTapHighlight { get; set; }
    [JsonProperty("apple-mobile-web-app-capable")]
    public string AppleMobileWebAppCapable { get; set; }
    [JsonProperty("mobile-web-app-capable")]
    public string MobileWebAppCapable { get; set; }
    [JsonProperty("og:url")]
    public string OgUrl { get; set; }
    [JsonProperty("format-detection")]
    public string FormatDetection { get; set; }
    [JsonProperty("og:site_name")]
    public string OgSiteName { get; set; }
    public string handheldfriendly { get; set; }
    [JsonProperty("og:locale")]
    public string OgLocale { get; set; }
    public string baidu_union_verify { get; set; }
    [JsonProperty("twitter:creator")]
    public string TwitterCreator { get; set; }
    public string news_keywords { get; set; }
    public DateTime? revision_date { get; set; }
    [JsonProperty("fb:admins")]
    public string FbAdmins { get; set; }
    public string headline { get; set; }
    [JsonProperty("yandex-verification")]
    public string YandexVerification { get; set; }
    [JsonProperty("dc.date.issued")]
    public object DcDateIssued { get; set; }
    public string scripdelaytimer { get; set; }
    public string originalpublicationdate { get; set; }
    public string ticker { get; set; }
    public string author { get; set; }
    [JsonProperty("og:article:published_time")]
    public string OgArticlePublishedTime { get; set; }
    public string title { get; set; }
    [JsonProperty("og:article:tag")]
    public string OgArticleTag { get; set; }
    [JsonProperty("original-source")]
    public string OriginalSource { get; set; }
    [JsonProperty("og:article:author")]
    public string OgArticleAuthor { get; set; }
    [JsonProperty("next-head-count")]
    public string NextHeadCount { get; set; }
    public string contenttype { get; set; }
}

public class Webpage
{
    public string maincontentofpage { get; set; }
    public string headline { get; set; }
}

public class Creativework
{
    public string datemodified { get; set; }
    public string name { get; set; }
    public string text { get; set; }
    public string headline { get; set; }
    public DateTime datepublished { get; set; }
    public string mainentityofpage { get; set; }
}

public class CseImage
{
    public string src { get; set; }
}

public class Blogposting
{
    public string datemodified { get; set; }
    public string author { get; set; }
    public string name { get; set; }
    public string headline { get; set; }
    public string datepublished { get; set; }
    public string mainentityofpage { get; set; }
}

public class Sitenavigationelement
{
    public string url { get; set; }
}

public class Listitem
{
    public string name { get; set; }
    public string position { get; set; }
    public string url { get; set; }
}

public class Corporation
{
    public string tickersymbol { get; set; }
    public string name { get; set; }
}

public class Article
{
    public string image { get; set; }
    public string articlebody { get; set; }
    public string author { get; set; }
    public string headline { get; set; }
    public string datepublished { get; set; }
}

public class Newsarticle
{
    public string wordcount { get; set; }
    public string isfamilyfriendly { get; set; }
    public string inlanguage { get; set; }
    public string dateline { get; set; }
    public string copyrightyear { get; set; }
    public string contentlocation { get; set; }
    public string author { get; set; }
    public string description { get; set; }
    public string copyrightholder { get; set; }
    public string articlebody { get; set; }
    public string datemodified { get; set; }
    public string provider { get; set; }
    public string headline { get; set; }
    public string datepublished { get; set; }
}

public class Pagemap
{
    public List<CseThumbnail> cse_thumbnail { get; set; }
    public List<Imageobject> imageobject { get; set; }
    public List<Person> person { get; set; }
    public List<Organization> organization { get; set; }
    public List<Metatag> metatags { get; set; }
    public List<Webpage> webpage { get; set; }
    public List<Creativework> creativework { get; set; }
    public List<CseImage> cse_image { get; set; }
    public List<Blogposting> blogposting { get; set; }
    public List<Sitenavigationelement> sitenavigationelement { get; set; }
    public List<Listitem> listitem { get; set; }
    public List<Corporation> corporation { get; set; }
    public List<Article> article { get; set; }
    public List<Newsarticle> newsarticle { get; set; }
}

public class Item
{
    public string kind { get; set; }
    public string title { get; set; }
    public string htmlTitle { get; set; }
    public string link { get; set; }
    public string displayLink { get; set; }
    public string snippet { get; set; }
    public string htmlSnippet { get; set; }
    public string cacheId { get; set; }
    public string formattedUrl { get; set; }
    public string htmlFormattedUrl { get; set; }
    public Pagemap pagemap { get; set; }
}

public class Root
{
    public string kind { get; set; }
    public Url url { get; set; }
    public Queries queries { get; set; }
    public Context context { get; set; }
    public SearchInformation searchInformation { get; set; }
    public List<Item> items { get; set; }
}

