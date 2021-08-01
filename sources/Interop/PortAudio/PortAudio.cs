// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
using System.Runtime.InteropServices;

namespace PortAudioCSharp.Interop
{
    public static unsafe partial class PortAudio
    {
        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int Pa_GetVersion();

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* Pa_GetVersionText();

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const PaVersionInfo *")]
        public static extern PaVersionInfo* Pa_GetVersionInfo();

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* Pa_GetErrorText([NativeTypeName("PaError")] int errorCode);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int Pa_Initialize();

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int Pa_Terminate();

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaHostApiIndex")]
        public static extern int Pa_GetHostApiCount();

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaHostApiIndex")]
        public static extern int Pa_GetDefaultHostApi();

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const PaHostApiInfo *")]
        public static extern PaHostApiInfo* Pa_GetHostApiInfo([NativeTypeName("PaHostApiIndex")] int hostApi);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaHostApiIndex")]
        public static extern int Pa_HostApiTypeIdToHostApiIndex(PaHostApiTypeId type);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaDeviceIndex")]
        public static extern int Pa_HostApiDeviceIndexToDeviceIndex([NativeTypeName("PaHostApiIndex")] int hostApi, int hostApiDeviceIndex);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const PaHostErrorInfo *")]
        public static extern PaHostErrorInfo* Pa_GetLastHostErrorInfo();

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaDeviceIndex")]
        public static extern int Pa_GetDeviceCount();

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaDeviceIndex")]
        public static extern int Pa_GetDefaultInputDevice();

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaDeviceIndex")]
        public static extern int Pa_GetDefaultOutputDevice();

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const PaDeviceInfo *")]
        public static extern PaDeviceInfo* Pa_GetDeviceInfo([NativeTypeName("PaDeviceIndex")] int device);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int Pa_IsFormatSupported([NativeTypeName("const PaStreamParameters *")] PaStreamParameters* inputParameters, [NativeTypeName("const PaStreamParameters *")] PaStreamParameters* outputParameters, double sampleRate);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int Pa_OpenStream([NativeTypeName("PaStream **")] void** stream, [NativeTypeName("const PaStreamParameters *")] PaStreamParameters* inputParameters, [NativeTypeName("const PaStreamParameters *")] PaStreamParameters* outputParameters, double sampleRate, [NativeTypeName("unsigned long")] uint framesPerBuffer, [NativeTypeName("PaStreamFlags")] uint streamFlags, [NativeTypeName("PaStreamCallback *")] delegate* unmanaged[Cdecl]<void*, void*, uint, PaStreamCallbackTimeInfo*, uint, void*, int>* streamCallback, void* userData);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int Pa_OpenDefaultStream([NativeTypeName("PaStream **")] void** stream, int numInputChannels, int numOutputChannels, [NativeTypeName("PaSampleFormat")] uint sampleFormat, double sampleRate, [NativeTypeName("unsigned long")] uint framesPerBuffer, [NativeTypeName("PaStreamCallback *")] delegate* unmanaged[Cdecl]<void*, void*, uint, PaStreamCallbackTimeInfo*, uint, void*, int>* streamCallback, void* userData);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int Pa_CloseStream([NativeTypeName("PaStream *")] void* stream);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int Pa_SetStreamFinishedCallback([NativeTypeName("PaStream *")] void* stream, [NativeTypeName("PaStreamFinishedCallback *")] delegate* unmanaged[Cdecl]<void*, void>* streamFinishedCallback);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int Pa_StartStream([NativeTypeName("PaStream *")] void* stream);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int Pa_StopStream([NativeTypeName("PaStream *")] void* stream);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int Pa_AbortStream([NativeTypeName("PaStream *")] void* stream);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int Pa_IsStreamStopped([NativeTypeName("PaStream *")] void* stream);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int Pa_IsStreamActive([NativeTypeName("PaStream *")] void* stream);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const PaStreamInfo *")]
        public static extern PaStreamInfo* Pa_GetStreamInfo([NativeTypeName("PaStream *")] void* stream);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaTime")]
        public static extern double Pa_GetStreamTime([NativeTypeName("PaStream *")] void* stream);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double Pa_GetStreamCpuLoad([NativeTypeName("PaStream *")] void* stream);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int Pa_ReadStream([NativeTypeName("PaStream *")] void* stream, void* buffer, [NativeTypeName("unsigned long")] uint frames);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int Pa_WriteStream([NativeTypeName("PaStream *")] void* stream, [NativeTypeName("const void *")] void* buffer, [NativeTypeName("unsigned long")] uint frames);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int Pa_GetStreamReadAvailable([NativeTypeName("PaStream *")] void* stream);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int Pa_GetStreamWriteAvailable([NativeTypeName("PaStream *")] void* stream);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int Pa_GetSampleSize([NativeTypeName("PaSampleFormat")] uint format);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void Pa_Sleep([NativeTypeName("long")] int msec);

        [NativeTypeName("#define paNoDevice ((PaDeviceIndex)-1)")]
        public const int paNoDevice = ((int)(-1));

        [NativeTypeName("#define paUseHostApiSpecificDeviceSpecification ((PaDeviceIndex)-2)")]
        public const int paUseHostApiSpecificDeviceSpecification = ((int)(-2));

        [NativeTypeName("#define paFloat32 ((PaSampleFormat) 0x00000001)")]
        public const uint paFloat32 = ((uint)(0x00000001));

        [NativeTypeName("#define paInt32 ((PaSampleFormat) 0x00000002)")]
        public const uint paInt32 = ((uint)(0x00000002));

        [NativeTypeName("#define paInt24 ((PaSampleFormat) 0x00000004)")]
        public const uint paInt24 = ((uint)(0x00000004));

        [NativeTypeName("#define paInt16 ((PaSampleFormat) 0x00000008)")]
        public const uint paInt16 = ((uint)(0x00000008));

        [NativeTypeName("#define paInt8 ((PaSampleFormat) 0x00000010)")]
        public const uint paInt8 = ((uint)(0x00000010));

        [NativeTypeName("#define paUInt8 ((PaSampleFormat) 0x00000020)")]
        public const uint paUInt8 = ((uint)(0x00000020));

        [NativeTypeName("#define paCustomFormat ((PaSampleFormat) 0x00010000)")]
        public const uint paCustomFormat = ((uint)(0x00010000));

        [NativeTypeName("#define paNonInterleaved ((PaSampleFormat) 0x80000000)")]
        public const uint paNonInterleaved = ((uint)(0x80000000));

        [NativeTypeName("#define paFormatIsSupported (0)")]
        public const int paFormatIsSupported = (0);

        [NativeTypeName("#define paFramesPerBufferUnspecified (0)")]
        public const int paFramesPerBufferUnspecified = (0);

        [NativeTypeName("#define paNoFlag ((PaStreamFlags) 0)")]
        public const uint paNoFlag = ((uint)(0));

        [NativeTypeName("#define paClipOff ((PaStreamFlags) 0x00000001)")]
        public const uint paClipOff = ((uint)(0x00000001));

        [NativeTypeName("#define paDitherOff ((PaStreamFlags) 0x00000002)")]
        public const uint paDitherOff = ((uint)(0x00000002));

        [NativeTypeName("#define paNeverDropInput ((PaStreamFlags) 0x00000004)")]
        public const uint paNeverDropInput = ((uint)(0x00000004));

        [NativeTypeName("#define paPrimeOutputBuffersUsingStreamCallback ((PaStreamFlags) 0x00000008)")]
        public const uint paPrimeOutputBuffersUsingStreamCallback = ((uint)(0x00000008));

        [NativeTypeName("#define paPlatformSpecificFlags ((PaStreamFlags)0xFFFF0000)")]
        public const uint paPlatformSpecificFlags = ((uint)(0xFFFF0000));

        [NativeTypeName("#define paInputUnderflow ((PaStreamCallbackFlags) 0x00000001)")]
        public const uint paInputUnderflow = ((uint)(0x00000001));

        [NativeTypeName("#define paInputOverflow ((PaStreamCallbackFlags) 0x00000002)")]
        public const uint paInputOverflow = ((uint)(0x00000002));

        [NativeTypeName("#define paOutputUnderflow ((PaStreamCallbackFlags) 0x00000004)")]
        public const uint paOutputUnderflow = ((uint)(0x00000004));

        [NativeTypeName("#define paOutputOverflow ((PaStreamCallbackFlags) 0x00000008)")]
        public const uint paOutputOverflow = ((uint)(0x00000008));

        [NativeTypeName("#define paPrimingOutput ((PaStreamCallbackFlags) 0x00000010)")]
        public const uint paPrimingOutput = ((uint)(0x00000010));

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaAsio_GetAvailableBufferSizes([NativeTypeName("PaDeviceIndex")] int device, [NativeTypeName("long *")] int* minBufferSizeFrames, [NativeTypeName("long *")] int* maxBufferSizeFrames, [NativeTypeName("long *")] int* preferredBufferSizeFrames, [NativeTypeName("long *")] int* granularity);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaAsio_ShowControlPanel([NativeTypeName("PaDeviceIndex")] int device, void* systemSpecific);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaAsio_GetInputChannelName([NativeTypeName("PaDeviceIndex")] int device, int channelIndex, [NativeTypeName("const char **")] sbyte** channelName);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaAsio_GetOutputChannelName([NativeTypeName("PaDeviceIndex")] int device, int channelIndex, [NativeTypeName("const char **")] sbyte** channelName);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaAsio_SetStreamSampleRate([NativeTypeName("PaStream *")] void* stream, double sampleRate);

        [NativeTypeName("#define PaAsio_GetAvailableLatencyValues PaAsio_GetAvailableBufferSizes")]
        public static readonly delegate*<int, int*, int*, int*, int*, int> PaAsio_GetAvailableLatencyValues = &PaAsio_GetAvailableBufferSizes;

        [NativeTypeName("#define paAsioUseChannelSelectors (0x01)")]
        public const int paAsioUseChannelSelectors = (0x01);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaJack_SetClientName([NativeTypeName("const char *")] sbyte* name);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaJack_GetClientName([NativeTypeName("const char **")] sbyte** clientName);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PaAlsa_InitializeStreamInfo(PaAlsaStreamInfo* info);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PaAlsa_EnableRealtimeScheduling([NativeTypeName("PaStream *")] void* s, int enable);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaAlsa_GetStreamInputCard([NativeTypeName("PaStream *")] void* s, int* card);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaAlsa_GetStreamOutputCard([NativeTypeName("PaStream *")] void* s, int* card);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaAlsa_SetNumPeriods(int numPeriods);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaAlsa_SetRetriesBusy(int retries);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PaAlsa_SetLibraryPathName([NativeTypeName("const char *")] sbyte* pathName);

        [NativeTypeName("#define paWinDirectSoundUseLowLevelLatencyParameters (0x01)")]
        public const int paWinDirectSoundUseLowLevelLatencyParameters = (0x01);

        [NativeTypeName("#define paWinDirectSoundUseChannelMask (0x04)")]
        public const int paWinDirectSoundUseChannelMask = (0x04);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaWasapi_GetAudioClient([NativeTypeName("PaStream *")] void* pStream, void** pAudioClient, int bOutput);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaWasapi_UpdateDeviceList();

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int PaWasapi_GetDeviceCurrentFormat([NativeTypeName("PaStream *")] void* pStream, void* pFormat, [NativeTypeName("unsigned int")] uint formatSize, int bOutput);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int PaWasapi_GetDeviceDefaultFormat(void* pFormat, [NativeTypeName("unsigned int")] uint formatSize, [NativeTypeName("PaDeviceIndex")] int device);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int PaWasapi_GetDeviceMixFormat(void* pFormat, [NativeTypeName("unsigned int")] uint formatSize, [NativeTypeName("PaDeviceIndex")] int device);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int PaWasapi_GetDeviceRole([NativeTypeName("PaDeviceIndex")] int device);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaWasapi_GetIMMDevice([NativeTypeName("PaDeviceIndex")] int device, void** pIMMDevice);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaWasapi_ThreadPriorityBoost(void** pTask, PaWasapiThreadPriority priorityClass);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaWasapi_ThreadPriorityRevert(void* pTask);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaWasapi_GetFramesPerHostBuffer([NativeTypeName("PaStream *")] void* pStream, [NativeTypeName("unsigned int *")] uint* pInput, [NativeTypeName("unsigned int *")] uint* pOutput);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaWasapi_GetJackCount([NativeTypeName("PaDeviceIndex")] int device, int* pJackCount);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaWasapi_GetJackDescription([NativeTypeName("PaDeviceIndex")] int device, int jackIndex, PaWasapiJackDescription* pJackDescription);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaWasapi_SetStreamStateHandler([NativeTypeName("PaStream *")] void* pStream, [NativeTypeName("PaWasapiStreamStateCallback")] delegate* unmanaged[Cdecl]<void*, uint, uint, void*, void> fnStateHandler, void* pUserData);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaWasapiWinrt_SetDefaultDeviceId([NativeTypeName("const unsigned short *")] ushort* pId, int bOutput);

        [DllImport("portaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("PaError")]
        public static extern int PaWasapiWinrt_PopulateDeviceList([NativeTypeName("const unsigned short **")] ushort** pId, [NativeTypeName("const unsigned short **")] ushort** pName, [NativeTypeName("const PaWasapiDeviceRole *")] PaWasapiDeviceRole* pRole, [NativeTypeName("unsigned int")] uint count, int bOutput);
    }
}
