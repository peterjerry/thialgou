/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.thialgou.commonWRAP {

using System;
using System.Runtime.InteropServices;

public class CommonFunction : CommonElt {
  private HandleRef swigCPtr;

  internal CommonFunction(IntPtr cPtr, bool cMemoryOwn) : base(commonWRAPPINVOKE.CommonFunction_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CommonFunction obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CommonFunction() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          commonWRAPPINVOKE.delete_CommonFunction(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CommonFunction(string strFuncName) : this(commonWRAPPINVOKE.new_CommonFunction(strFuncName), true) {
    if (commonWRAPPINVOKE.SWIGPendingException.Pending) throw commonWRAPPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string getFuncName() {
    string ret = commonWRAPPINVOKE.CommonFunction_getFuncName(swigCPtr);
    return ret;
  }

}

}
