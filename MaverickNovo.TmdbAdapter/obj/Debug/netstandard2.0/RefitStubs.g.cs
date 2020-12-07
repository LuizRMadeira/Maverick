﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using MaverickNovo.TmdbAdapter.RefitInternalGenerated;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace MaverickNovo.TmdbAdapter.RefitInternalGenerated
{
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning disable CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
namespace MaverickNovo.TmdbAdapter.Clients
{
    using global::Refit;
    using global::System.Threading.Tasks;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedITmdbApi : ITmdbApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedITmdbApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<TmdbSearchMoviesGetResult> ITmdbApi.SearchMovies(TmdbSearchMoviesGet tmdbSearchMoviesGet)
        {
            var arguments = new object[] { tmdbSearchMoviesGet };
            var func = requestBuilder.BuildRestResultFuncForMethod("SearchMovies", new Type[] { typeof(TmdbSearchMoviesGet) });
            return (Task<TmdbSearchMoviesGetResult>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<TmdbSearchPersonsGetResult> ITmdbApi.SearchPersons(TmdbSearchPersonsGet tmdbSearchPersonsGet)
        {
            var arguments = new object[] { tmdbSearchPersonsGet };
            var func = requestBuilder.BuildRestResultFuncForMethod("SearchPersons", new Type[] { typeof(TmdbSearchPersonsGet) });
            return (Task<TmdbSearchPersonsGetResult>)func(Client, arguments);
        }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning restore CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
