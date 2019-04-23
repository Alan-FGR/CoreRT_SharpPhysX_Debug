using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using static physx;

public static partial class SharpPhysX{
    public const string Lib = "LibSharpPhysX.dll";
}

public static unsafe partial class physx
{
    public unsafe partial struct PxFoundationPtr
    {
        private System.IntPtr nativePtr_;
    }

    public static physx.PxPhysicsPtr PxCreatePhysics(uint version, physx.PxFoundationPtr foundation, physx.PxTolerancesScale scale) {
        return PxCreatePhysics(version, foundation, (physx.PxTolerancesScale*)&scale);
    }

    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    internal static extern physx.PxPhysicsPtr PxPhysicsPtr_PxCreatePhysicsPtr_uint_PxFoundationPtr_PxTolerancesScale_(uint pvk_version, physx.PxFoundationPtr pvk_foundation, physx.PxTolerancesScale* pvk_scale);

    public static physx.PxPhysicsPtr PxCreatePhysics(uint version, physx.PxFoundationPtr foundation, physx.PxTolerancesScale* scale) {
        uint pvk_in_version = version;
        physx.PxFoundationPtr pvk_in_foundation = foundation;
        physx.PxTolerancesScale* pvk_in_scale = scale;
        return PxPhysicsPtr_PxCreatePhysicsPtr_uint_PxFoundationPtr_PxTolerancesScale_(pvk_in_version, pvk_in_foundation, pvk_in_scale);
    }

    public unsafe partial struct PxPhysicsPtr
    {
        private System.IntPtr nativePtr_;

        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern physx.PxScenePtr PxScenePtr_PxPhysicsPtr_createScenePtr_PxSceneDescPtr_(physx.PxPhysicsPtr pvk_this, physx.PxSceneDescPtr pvk_sceneDesc);

        public physx.PxScenePtr createScene(physx.PxSceneDescPtr sceneDesc) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxSceneDescPtr pvk_in_sceneDesc = sceneDesc;
            return PxScenePtr_PxPhysicsPtr_createScenePtr_PxSceneDescPtr_(pvk_in_this, pvk_in_sceneDesc);
        }

        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern physx.PxMaterialPtr PxMaterialPtr_PxPhysicsPtr_createMaterialPtr_float_float_float_(physx.PxPhysicsPtr pvk_this, float pvk_staticFriction, float pvk_dynamicFriction, float pvk_restitution);

        public physx.PxMaterialPtr createMaterial(float staticFriction, float dynamicFriction, float restitution) {
            physx.PxPhysicsPtr pvk_in_this = this;
            float pvk_in_staticFriction = staticFriction;
            float pvk_in_dynamicFriction = dynamicFriction;
            float pvk_in_restitution = restitution;
            return PxMaterialPtr_PxPhysicsPtr_createMaterialPtr_float_float_float_(pvk_in_this, pvk_in_staticFriction, pvk_in_dynamicFriction, pvk_in_restitution);
        }
    }

    
    public enum PxGeometryTypeEnum : int {
        eSPHERE = 0,         // eSPHERE
        ePLANE = 1,          // ePLANE
        eCAPSULE = 2,        // eCAPSULE
        eBOX = 3,            // eBOX
        eCONVEXMESH = 4,     // eCONVEXMESH
        eTRIANGLEMESH = 5,   // eTRIANGLEMESH
        eHEIGHTFIELD = 6,    // eHEIGHTFIELD
        eGEOMETRY_COUNT = 7, // eGEOMETRY_COUNT
        eINVALID = -1,       // eINVALID = -1
    }

    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public unsafe partial struct PxGeometry : physx.PxGeometry.IPxGeometry
    {
        internal physx.PxGeometryTypeEnum mType;

        public unsafe interface IPxGeometry {
        }
    }

    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public unsafe partial struct PxBoxGeometry : physx.PxGeometry.IPxGeometry
    {
        internal PxGeometryTypeEnum mType;
        public physx.PxVec3 halfExtents;

        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void void_PxBoxGeometry_PxBoxGeometryPtr_Ctor_float_float_float_(PxBoxGeometry* pvk_this, float pvk_hx, float pvk_hy, float pvk_hz);

        public PxBoxGeometry(float hx, float hy, float hz)
        {

            float pvk_in_hx = hx;
            float pvk_in_hy = hy;
            float pvk_in_hz = hz;
            PxBoxGeometry toInit;
            var pvk_in_this = &toInit;
            void_PxBoxGeometry_PxBoxGeometryPtr_Ctor_float_float_float_(pvk_in_this, pvk_in_hx, pvk_in_hy,
                pvk_in_hz);
            this = toInit;
        }
    }

    public unsafe partial struct PxMaterialPtr //: physx.PxBasePtr.IPxBasePtr
    {
        private System.IntPtr nativePtr_;
    }

    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public unsafe partial struct PxTolerancesScale {
        public float length;
        public float speed;

        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Default_PxTolerancesScale_(physx.PxTolerancesScale* pvk_RetRef);

        public static physx.PxTolerancesScale Default() {
            physx.PxTolerancesScale RetRef;
            Default_PxTolerancesScale_(&RetRef);
            return RetRef;
        }
    }

    public unsafe partial struct PxCpuDispatcherPtr //: physx.PxCpuDispatcherPtr.IPxCpuDispatcherPtr
    {
        private System.IntPtr nativePtr_;
    }

    public unsafe partial struct PxSceneDescPtr
    {
        private System.IntPtr nativePtr_;

        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern physx.PxSceneDescPtr Ctor_PxSceneDescPtr_PxTolerancesScale_(physx.PxTolerancesScale* pvk_scale);

        public static physx.PxSceneDescPtr New(physx.PxTolerancesScale* scale)
        {
            physx.PxTolerancesScale* pvk_in_scale = scale;
            return Ctor_PxSceneDescPtr_PxTolerancesScale_(pvk_in_scale);
        }

        public static physx.PxSceneDescPtr New(physx.PxTolerancesScale scale)
        {
            return New((physx.PxTolerancesScale*)&scale);
        }

        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void PxSceneDescPtr_GET_gravity(physx.PxSceneDescPtr cls, physx.PxVec3* GetRetRef);
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void PxSceneDescPtr_SET_gravity(physx.PxSceneDescPtr cls, physx.PxVec3 value);

        public physx.PxVec3 gravity {
            get { physx.PxVec3 GetRetRef; PxSceneDescPtr_GET_gravity(this, &GetRetRef); return GetRetRef; }
            set => PxSceneDescPtr_SET_gravity(this, value);
        }

        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern PxSimulationFilterShader PxSceneDescPtr_GET_filterShader(physx.PxSceneDescPtr cls);
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void PxSceneDescPtr_SET_filterShader(physx.PxSceneDescPtr cls, PxSimulationFilterShader value);

        public PxSimulationFilterShader filterShader {
            get => PxSceneDescPtr_GET_filterShader(this);
            set => PxSceneDescPtr_SET_filterShader(this, value);
        }

        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern physx.PxCpuDispatcherPtr PxSceneDescPtr_GET_cpuDispatcher(physx.PxSceneDescPtr cls);
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void PxSceneDescPtr_SET_cpuDispatcher(physx.PxSceneDescPtr cls, physx.PxCpuDispatcherPtr value);

        public physx.PxCpuDispatcherPtr cpuDispatcher {
            get => PxSceneDescPtr_GET_cpuDispatcher(this);
            set => PxSceneDescPtr_SET_cpuDispatcher(this, value);
        }
    }

    [StructLayout(LayoutKind.Sequential, Size = 12)]
    public unsafe partial struct PxVec3
    {
        public float x;
        public float y;
        public float z;

        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void void_PxVec3_PxVec3Ptr_Ctor_float_float_float_(physx.PxVec3* pvk_this, float pvk_nx,
            float pvk_ny, float pvk_nz);

        public PxVec3(float nx, float ny, float nz)
        {

            float pvk_in_nx = nx;
            float pvk_in_ny = ny;
            float pvk_in_nz = nz;
            PxVec3 toInit;
            var pvk_in_this = &toInit;
            void_PxVec3_PxVec3Ptr_Ctor_float_float_float_(pvk_in_this, pvk_in_nx, pvk_in_ny, pvk_in_nz);
            this = toInit;
        }
    }

    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    internal static extern physx.PxDefaultCpuDispatcherPtr PxDefaultCpuDispatcherPtr_PxDefaultCpuDispatcherCreatePtr_uint_(uint pvk_numThreads);

    public static physx.PxDefaultCpuDispatcherPtr PxDefaultCpuDispatcherCreate(uint numThreads) {
        uint pvk_in_numThreads = numThreads;
        return PxDefaultCpuDispatcherPtr_PxDefaultCpuDispatcherCreatePtr_uint_(pvk_in_numThreads);
    }

    public unsafe partial struct PxDefaultCpuDispatcherPtr //: physx.PxCpuDispatcherPtr.IPxCpuDispatcherPtr
    {
        private System.IntPtr nativePtr_;
        public static implicit operator physx.PxCpuDispatcherPtr(PxDefaultCpuDispatcherPtr obj) => *(physx.PxCpuDispatcherPtr*)&obj;
    }

    public static uint PX_PHYSICS_VERSION => SharpPhysX_internal.GetPhysicsVersion();

    public static PxSimulationFilterShader PxDefaultSimulationFilterShader =>
        SharpPhysX_internal.GetDefaultSimulationFilterShader();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint PxSimulationFilterShader();

    public unsafe partial struct PxScenePtr
    {
        private System.IntPtr nativePtr_;

        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void void_PxScenePtr_simulatePtr_float_(physx.PxScenePtr pvk_this, float pvk_elapsedTime);

        public void simulate(float elapsedTime) {
            physx.PxScenePtr pvk_in_this = this;
            float pvk_in_elapsedTime = elapsedTime;
            void_PxScenePtr_simulatePtr_float_(pvk_in_this, pvk_in_elapsedTime);
        }

        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool bool_PxScenePtr_fetchResultsPtr_bool_(physx.PxScenePtr pvk_this, bool pvk_block);

        public bool fetchResults(bool block=false) {
            physx.PxScenePtr pvk_in_this = this;
            bool pvk_in_block = block;
            return bool_PxScenePtr_fetchResultsPtr_bool_(pvk_in_this, pvk_in_block);
        }

        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void void_PxScenePtr_addActorPtr_PxActorPtr_(physx.PxScenePtr pvk_this, physx.PxActorPtr pvk_actor);

        public void addActor(physx.PxActorPtr actor) {
            physx.PxScenePtr pvk_in_this = this;
            physx.PxActorPtr pvk_in_actor = actor;
            void_PxScenePtr_addActorPtr_PxActorPtr_(pvk_in_this, pvk_in_actor);
        }
    }

    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public unsafe partial struct PxQuat
    {
        public float x;
        public float y;
        public float z;
        public float w;
    }

    [StructLayout(LayoutKind.Sequential, Size = 28)]
    public unsafe partial struct PxTransform
    {
        public physx.PxQuat q;
        public physx.PxVec3 p;

        public PxTransform(physx.PxVec3 position) : this((physx.PxVec3*)&position) {
            //ctor piping;
        }

        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void void_PxTransform_PxTransformPtr_Ctor_PxVec3_(physx.PxTransform* pvk_this, physx.PxVec3* pvk_position);

        public PxTransform(physx.PxVec3* position) {

            physx.PxVec3* pvk_in_position = position;
            PxTransform toInit;
            var pvk_in_this = &toInit;
            void_PxTransform_PxTransformPtr_Ctor_PxVec3_(pvk_in_this, pvk_in_position);
            this = toInit;
        }
    }

    public unsafe partial struct PxActorPtr //: physx.PxActorPtr.IPxActorPtr, physx.PxBasePtr.IPxBasePtr
    {
        private System.IntPtr nativePtr_;
    }

    public static physx.PxRigidStaticPtr PxCreatePlane(physx.PxPhysicsPtr sdk, physx.PxPlane plane, physx.PxMaterialPtr material) {
        return PxCreatePlane(sdk, (physx.PxPlane*)&plane, material);
    }

    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    internal static extern physx.PxRigidStaticPtr PxRigidStaticPtr_PxCreatePlanePtr_PxPhysicsPtr_PxPlane_PxMaterialPtr_(physx.PxPhysicsPtr pvk_sdk, physx.PxPlane* pvk_plane, physx.PxMaterialPtr pvk_material);

    public static physx.PxRigidStaticPtr PxCreatePlane(physx.PxPhysicsPtr sdk, physx.PxPlane* plane, physx.PxMaterialPtr material) {
        physx.PxPhysicsPtr pvk_in_sdk = sdk;
        physx.PxPlane* pvk_in_plane = plane;
        physx.PxMaterialPtr pvk_in_material = material;
        return PxRigidStaticPtr_PxCreatePlanePtr_PxPhysicsPtr_PxPlane_PxMaterialPtr_(pvk_in_sdk, pvk_in_plane, pvk_in_material);
    }

    public unsafe partial struct PxRigidStaticPtr //: physx.PxRigidActorPtr.IPxRigidActorPtr, physx.PxActorPtr.IPxActorPtr, physx.PxBasePtr.IPxBasePtr
    {
        private System.IntPtr nativePtr_;
        public static implicit operator physx.PxActorPtr(PxRigidStaticPtr obj) => *(physx.PxActorPtr*)&obj;
    }

    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public unsafe partial struct PxPlane
    {
        public physx.PxVec3 n;
        public float d;

        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void void_PxPlane_PxPlanePtr_Ctor_float_float_float_float_(physx.PxPlane* pvk_this, float pvk_nx, float pvk_ny, float pvk_nz, float pvk_distance);

        public PxPlane(float nx, float ny, float nz, float distance) {
            float pvk_in_nx = nx;
            float pvk_in_ny = ny;
            float pvk_in_nz = nz;
            float pvk_in_distance = distance;
            PxPlane toInit;
            var pvk_in_this = &toInit;
            void_PxPlane_PxPlanePtr_Ctor_float_float_float_float_(pvk_in_this, pvk_in_nx, pvk_in_ny, pvk_in_nz, pvk_in_distance);
            this = toInit;
        }
    }

    public unsafe partial struct PxRigidDynamicPtr //: physx.PxRigidBodyPtr.IPxRigidBodyPtr, physx.PxRigidActorPtr.IPxRigidActorPtr, physx.PxActorPtr.IPxActorPtr, physx.PxBasePtr.IPxBasePtr {
    {
        private System.IntPtr nativePtr_;
        public static implicit operator physx.PxActorPtr(PxRigidDynamicPtr obj) => *(physx.PxActorPtr*)&obj;

        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void PxTransform_const_PxRigidActorPtr_getGlobalPosePtr(physx.PxTransform* pvk_RetRef, physx.PxRigidDynamicPtr pvk_this);

        public physx.PxTransform getGlobalPose() {
            physx.PxTransform RetRef;
            physx.PxRigidDynamicPtr pvk_in_this = this;
            PxTransform_const_PxRigidActorPtr_getGlobalPosePtr(&RetRef, pvk_in_this);
            return RetRef;
        }
    }

    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    internal static extern physx.PxFoundationPtr PxFoundationPtr_SharpPhysX_CreateFoundationPtr();

    public static physx.PxRigidDynamicPtr PxCreateDynamic<T3>(physx.PxPhysicsPtr sdk, physx.PxTransform transform, T3 geometry, physx.PxMaterialPtr material, float density) where T3 : unmanaged, physx.PxGeometry.IPxGeometry {
        return PxCreateDynamic(sdk, (physx.PxTransform*)&transform, (physx.PxGeometry*)&geometry, material, density);
    }

    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    internal static extern physx.PxRigidDynamicPtr PxRigidDynamicPtr_PxCreateDynamicPtr_PxPhysicsPtr_PxTransform_PxGeometry_PxMaterialPtr_float_(physx.PxPhysicsPtr pvk_sdk, physx.PxTransform* pvk_transform, physx.PxGeometry* pvk_geometry, physx.PxMaterialPtr pvk_material, float pvk_density);

    public static physx.PxRigidDynamicPtr PxCreateDynamic(physx.PxPhysicsPtr sdk, physx.PxTransform* transform, physx.PxGeometry* geometry, physx.PxMaterialPtr material, float density) {
        physx.PxPhysicsPtr pvk_in_sdk = sdk;
        physx.PxTransform* pvk_in_transform = transform;
        physx.PxGeometry* pvk_in_geometry = geometry;
        physx.PxMaterialPtr pvk_in_material = material;
        float pvk_in_density = density;
        return PxRigidDynamicPtr_PxCreateDynamicPtr_PxPhysicsPtr_PxTransform_PxGeometry_PxMaterialPtr_float_(pvk_in_sdk, pvk_in_transform, pvk_in_geometry, pvk_in_material, pvk_in_density);
    }
}

public static unsafe partial class SharpPhysX_internal {

    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    internal static extern uint uint_SharpPhysX_internal_GetPhysicsVersionPtr();

    public static uint GetPhysicsVersion() {
        return uint_SharpPhysX_internal_GetPhysicsVersionPtr();
    }

    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    internal static extern PxSimulationFilterShader PxSimulationFilterShader_SharpPhysX_internal_GetDefaultSimulationFilterShaderPtr();

    public static PxSimulationFilterShader GetDefaultSimulationFilterShader() {
        return PxSimulationFilterShader_SharpPhysX_internal_GetDefaultSimulationFilterShaderPtr();
    }
}

class SampleHelloWorld
{
    PxFoundationPtr gFoundation;
    PxPhysicsPtr gPhysics;
    PxDefaultCpuDispatcherPtr gDispatcher;
    PxScenePtr gScene;
    PxMaterialPtr gMaterial;

    void initPhysics(bool interactive)
    {
        gFoundation = PxFoundationPtr_SharpPhysX_CreateFoundationPtr();

        gPhysics = PxCreatePhysics(PX_PHYSICS_VERSION, gFoundation, PxTolerancesScale.Default());

        var sceneDesc = PxSceneDescPtr.New(PxTolerancesScale.Default());
        sceneDesc.gravity = new PxVec3(0, -9.81f, 0);
        gDispatcher = PxDefaultCpuDispatcherCreate(2);
        sceneDesc.cpuDispatcher = gDispatcher;
        sceneDesc.filterShader = PxDefaultSimulationFilterShader;
        gScene = gPhysics.createScene(sceneDesc);

        gMaterial = gPhysics.createMaterial(.5f, .5f, .6f);

        var groundPlane = PxCreatePlane(gPhysics, new PxPlane(0, 1, 0, 0), gMaterial);
        gScene.addActor(groundPlane);
        
        var geometry = new PxBoxGeometry(0.5f, 0.5f, 0.5f);

        var transform = new PxTransform(new PxVec3(0, 15, 0));
        PxRigidDynamicPtr dynamic = PxCreateDynamic(gPhysics, transform, geometry, gMaterial, 10);
        gScene.addActor(dynamic);
        DEBUG = dynamic;
    }

    PxRigidDynamicPtr DEBUG;

    void stepPhysics(bool interactive)
    {
        float freqHz = 20;

        gScene.simulate(1 / freqHz);
        gScene.fetchResults(true);

        var p = DEBUG.getGlobalPose().p;
        System.Console.WriteLine(new string('█', (int)(p.y*10)));

        Thread.Sleep((int)(1 / freqHz * 1000));
    }

//    void cleanupPhysics(bool interactive)
//    {
////        gScene.release();
////        gDispatcher.release();
////        gPhysics.release();
////        gFoundation.release();
//        System.Console.WriteLine("SnippetHelloWorld done.");
//    }

    public SampleHelloWorld()
    {
        initPhysics(false);

        for (int i = 0; i < 1000; i++)
        {
            stepPhysics(false);
        }

        //cleanupPhysics(false);
    }

    public static void Main()
    {
        new SampleHelloWorld();
        Console.WriteLine("main done");
    }
}


