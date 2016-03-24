// Generated from SessionListener.h

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;

namespace AllJoynDotNet
{
		/// <summary>
		/// Copyright AllSeen Alliance. All rights reserved.
		/// </summary>
		/// <remarks>
		/// <para>Permission to use, copy, modify, and/or distribute this software for any
		/// purpose with or without fee is hereby granted, provided that the above
		/// copyright notice and this permission notice appear in all copies.
		/// </para>
		/// <para>THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
		/// WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
		/// MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
		/// ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
		/// WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
		/// ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
		/// OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.
		/// </para>
		/// </remarks>
		/// 
		internal enum alljoyn_sessionlostreason
		{
		
		ALLJOYN_SESSIONLOST_INVALID                      = 0x00, /**< Invalid */
		ALLJOYN_SESSIONLOST_REMOTE_END_LEFT_SESSION      = 0x01, /**< Remote end called LeaveSession */
		ALLJOYN_SESSIONLOST_REMOTE_END_CLOSED_ABRUPTLY   = 0x02, /**< Remote end closed abruptly */
		ALLJOYN_SESSIONLOST_REMOVED_BY_BINDER            = 0x03, /**< Session binder removed this endpoint by calling RemoveSessionMember */
		ALLJOYN_SESSIONLOST_LINK_TIMEOUT                 = 0x04, /**< Link was timed-out */
		ALLJOYN_SESSIONLOST_REASON_OTHER                 = 0x05 /**< Unspecified reason for session loss */
		
		}
		// typedef enum {
		// ALLJOYN_SESSIONLOST_INVALID                      = 0x00, /**< Invalid */
		// ALLJOYN_SESSIONLOST_REMOTE_END_LEFT_SESSION      = 0x01, /**< Remote end called LeaveSession */
		// ALLJOYN_SESSIONLOST_REMOTE_END_CLOSED_ABRUPTLY   = 0x02, /**< Remote end closed abruptly */
		// ALLJOYN_SESSIONLOST_REMOVED_BY_BINDER            = 0x03, /**< Session binder removed this endpoint by calling RemoveSessionMember */
		// ALLJOYN_SESSIONLOST_LINK_TIMEOUT                 = 0x04, /**< Link was timed-out */
		// ALLJOYN_SESSIONLOST_REASON_OTHER                 = 0x05 /**< Unspecified reason for session loss */
		// } alljoyn_sessionlostreason;
		// 

		/// <summary>
		/// Type for the SesionLost callback.
		/// </summary>
		/// <remarks>
		/// <para>Called by the bus when an existing session becomes disconnected.
		/// </para>
		/// </remarks>
		/// <param name="context">context pointer that was passed into the alljoyn_sessionlistener_create function</param>
		/// <param name="alljoyn_sessionid">Id of session that was lost.</param>
		/// <param name="reason">The reason for the session being lost</param>
		/// 
		internal delegate void alljoyn_sessionlistener_sessionlost_ptr(IntPtr context, IntPtr sessionId, alljoyn_sessionlostreason reason);
		// typedef void (AJ_CALL * alljoyn_sessionlistener_sessionlost_ptr)(const void* context, alljoyn_sessionid sessionId, alljoyn_sessionlostreason reason);
		// 

		/// <summary>
		/// Type for the SessionMemberAdded callback.
		/// </summary>
		/// <remarks>
		/// <para>Called by the bus when a member of a multipoint session is added.
		/// </para>
		/// </remarks>
		/// <param name="context">context pointer that was passed into the alljoyn_sessionlistener_create function</param>
		/// <param name="alljoyn_sessionid">Id of session whose member(s) changed.</param>
		/// <param name="uniqueName">Unique name of member who was added.</param>
		/// 
		internal delegate void alljoyn_sessionlistener_sessionmemberadded_ptr(IntPtr context, IntPtr sessionId, [MarshalAs(UnmanagedType.LPStr)]string uniqueName);
		// typedef void (AJ_CALL * alljoyn_sessionlistener_sessionmemberadded_ptr)(const void* context, alljoyn_sessionid sessionId,
		// const char* uniqueName);
		// 

		/// <summary>
		/// Type for the SessionMemberRemoved callback.
		/// </summary>
		/// <remarks>
		/// <para>Called by the bus when a member of a multipoint session is removed.
		/// </para>
		/// </remarks>
		/// <param name="context">context pointer that was passed into the alljoyn_sessionlistener_create function</param>
		/// <param name="alljoyn_sessionid">Id of session whose member(s) changed.</param>
		/// <param name="uniqueName">Unique name of member who was removed.</param>
		/// 
		internal delegate void alljoyn_sessionlistener_sessionmemberremoved_ptr(IntPtr context, IntPtr sessionId, [MarshalAs(UnmanagedType.LPStr)]string uniqueName);
		// typedef void (AJ_CALL * alljoyn_sessionlistener_sessionmemberremoved_ptr)(const void* context, alljoyn_sessionid sessionId,
		// const char* uniqueName);
		// 

		/// <summary>
		/// Structure used during alljoyn_sessionlistener_create to provide callbacks into C.
		/// </summary>
		/// 
		[StructLayout(LayoutKind.Sequential)]
		internal partial class alljoyn_sessionlistener_callbacks
		{
			public alljoyn_sessionlistener_sessionlost_ptr session_lost;
			public alljoyn_sessionlistener_sessionmemberadded_ptr session_member_added;
			public alljoyn_sessionlistener_sessionmemberremoved_ptr session_member_removed;
			//
			///**
			//* Called by the bus when an existing session becomes disconnected.
			//*/
			//alljoyn_sessionlistener_sessionlost_ptr session_lost;
			///**
			//* Called by the bus when a member of a multipoint session is added.
			//*/
			//alljoyn_sessionlistener_sessionmemberadded_ptr session_member_added;
			///**
			//* Called by the bus when a member of a multipoint session is removed.
			//*/
			//alljoyn_sessionlistener_sessionmemberremoved_ptr session_member_removed;
			//
		}
		// typedef struct {
		// /**
		// * Called by the bus when an existing session becomes disconnected.
		// */
		// alljoyn_sessionlistener_sessionlost_ptr session_lost;
		// /**
		// * Called by the bus when a member of a multipoint session is added.
		// */
		// alljoyn_sessionlistener_sessionmemberadded_ptr session_member_added;
		// /**
		// * Called by the bus when a member of a multipoint session is removed.
		// */
		// alljoyn_sessionlistener_sessionmemberremoved_ptr session_member_removed;
		// } alljoyn_sessionlistener_callbacks;
		// 

//
    public partial class SessionListener : AllJoynWrapper
    {
        internal SessionListener(IntPtr handle) : base(handle) { }
		/// <summary>
		/// Create an alljoyn_sessionlistener which will trigger the provided callbacks,
		/// passing along the provided context.
		/// </summary>
		/// <param name="callbacks">Callbacks to trigger for associated events.</param>
		/// <param name="context">Context to pass to callback functions</param>
		/// <returns>Handle to newly allocated alljoyn_sessionlistener.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern IntPtr alljoyn_sessionlistener_create(alljoyn_sessionlistener_callbacks callbacks, IntPtr context);
		// extern AJ_API alljoyn_sessionlistener AJ_CALL alljoyn_sessionlistener_create(const alljoyn_sessionlistener_callbacks* callbacks,const void* context);

		/// <summary>
		/// Destroy an alljoyn_sessionlistener.
		/// </summary>
		/// <param name="listener">alljoyn_sessionlistener to destroy.</param>
		/// 
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern IntPtr alljoyn_sessionlistener_destroy(IntPtr listener);
		// extern AJ_API void AJ_CALL alljoyn_sessionlistener_destroy(alljoyn_sessionlistener listener);


    }
}