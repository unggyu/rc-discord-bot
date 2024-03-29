﻿using HtmlAgilityPack;
using RC.KeywordRank.Constants;
using RC.KeywordRank.Extensions;
using System.Threading.Tasks;

namespace RC.KeywordRank.Helpers
{
    /// <summary>
    /// 키워드 순위 파서
    /// </summary>
    public class KeywordRankParser
    {
        #region Properties
        /// <summary>
        /// 검색 엔진
        /// </summary>
        public SearchEngine SearchEngine { get; protected internal set; }

        /// <summary>
        /// 키워드 순위 주소
        /// </summary>
        protected internal string KeywordRankUrl
        {
            get => SearchEngine.GetSearchEngineInfo().KeywordRankInfo.Url;
        }
        #endregion

        #region Methods
        /// <summary>
        /// 검색 엔진 Url의 Html을 제공 (비동기)
        /// </summary>
        /// <returns>Html source</returns>
        protected internal virtual async Task<string> GetHtmlAsync()
        {
            return await HtmlHelper.GetHtmlAsync(KeywordRankUrl);
        }

        /// <summary>
        /// 검색 엔진 Url의 HtmlDocument를 제공 (비동기)
        /// </summary>
        /// <returns>HtmlDocument</returns>
        protected internal virtual async Task<HtmlDocument> GetHtmlDocumentAsync()
        {
            return await HtmlHelper.GetHtmlDocumentAsync(KeywordRankUrl);
        }
        #endregion
    }
}
