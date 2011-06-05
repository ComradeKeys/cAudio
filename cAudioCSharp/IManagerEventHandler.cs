/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace cAudio {

using System;
using System.Runtime.InteropServices;

public class IManagerEventHandler : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IManagerEventHandler(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(IManagerEventHandler obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~IManagerEventHandler() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          cAudioCSharpWrapperPINVOKE.delete_IManagerEventHandler(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual void onInit() {
    cAudioCSharpWrapperPINVOKE.IManagerEventHandler_onInit(swigCPtr);
  }

  public virtual void onUpdate() {
    cAudioCSharpWrapperPINVOKE.IManagerEventHandler_onUpdate(swigCPtr);
  }

  public virtual void onRelease() {
    cAudioCSharpWrapperPINVOKE.IManagerEventHandler_onRelease(swigCPtr);
  }

  public virtual void onSourceCreate() {
    cAudioCSharpWrapperPINVOKE.IManagerEventHandler_onSourceCreate(swigCPtr);
  }

  public virtual void onDecoderRegister() {
    cAudioCSharpWrapperPINVOKE.IManagerEventHandler_onDecoderRegister(swigCPtr);
  }

  public virtual void onDataSourceRegister() {
    cAudioCSharpWrapperPINVOKE.IManagerEventHandler_onDataSourceRegister(swigCPtr);
  }

  public IManagerEventHandler() : this(cAudioCSharpWrapperPINVOKE.new_IManagerEventHandler(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("onInit", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateIManagerEventHandler_0(SwigDirectoronInit);
    if (SwigDerivedClassHasMethod("onUpdate", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateIManagerEventHandler_1(SwigDirectoronUpdate);
    if (SwigDerivedClassHasMethod("onRelease", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateIManagerEventHandler_2(SwigDirectoronRelease);
    if (SwigDerivedClassHasMethod("onSourceCreate", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateIManagerEventHandler_3(SwigDirectoronSourceCreate);
    if (SwigDerivedClassHasMethod("onDecoderRegister", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateIManagerEventHandler_4(SwigDirectoronDecoderRegister);
    if (SwigDerivedClassHasMethod("onDataSourceRegister", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateIManagerEventHandler_5(SwigDirectoronDataSourceRegister);
    cAudioCSharpWrapperPINVOKE.IManagerEventHandler_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(IManagerEventHandler));
    return hasDerivedMethod;
  }

  private void SwigDirectoronInit() {
    onInit();
  }

  private void SwigDirectoronUpdate() {
    onUpdate();
  }

  private void SwigDirectoronRelease() {
    onRelease();
  }

  private void SwigDirectoronSourceCreate() {
    onSourceCreate();
  }

  private void SwigDirectoronDecoderRegister() {
    onDecoderRegister();
  }

  private void SwigDirectoronDataSourceRegister() {
    onDataSourceRegister();
  }

  public delegate void SwigDelegateIManagerEventHandler_0();
  public delegate void SwigDelegateIManagerEventHandler_1();
  public delegate void SwigDelegateIManagerEventHandler_2();
  public delegate void SwigDelegateIManagerEventHandler_3();
  public delegate void SwigDelegateIManagerEventHandler_4();
  public delegate void SwigDelegateIManagerEventHandler_5();

  private SwigDelegateIManagerEventHandler_0 swigDelegate0;
  private SwigDelegateIManagerEventHandler_1 swigDelegate1;
  private SwigDelegateIManagerEventHandler_2 swigDelegate2;
  private SwigDelegateIManagerEventHandler_3 swigDelegate3;
  private SwigDelegateIManagerEventHandler_4 swigDelegate4;
  private SwigDelegateIManagerEventHandler_5 swigDelegate5;

  private static Type[] swigMethodTypes0 = new Type[] {  };
  private static Type[] swigMethodTypes1 = new Type[] {  };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] {  };
  private static Type[] swigMethodTypes4 = new Type[] {  };
  private static Type[] swigMethodTypes5 = new Type[] {  };
}

}
