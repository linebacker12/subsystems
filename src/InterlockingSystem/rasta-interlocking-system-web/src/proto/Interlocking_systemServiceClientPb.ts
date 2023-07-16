/**
 * @fileoverview gRPC-Web generated client stub for interlocking_system
 * @enhanceable
 * @public
 */

// Code generated by protoc-gen-grpc-web. DO NOT EDIT.
// versions:
// 	protoc-gen-grpc-web v1.4.2
// 	protoc              v3.21.12
// source: interlocking_system.proto


/* eslint-disable */
// @ts-nocheck


import * as grpcWeb from 'grpc-web';

import * as interlocking_system_pb from './interlocking_system_pb';


export class InterlockingSystemClient {
  client_: grpcWeb.AbstractClientBase;
  hostname_: string;
  credentials_: null | { [index: string]: string; };
  options_: null | { [index: string]: any; };

  constructor (hostname: string,
               credentials?: null | { [index: string]: string; },
               options?: null | { [index: string]: any; }) {
    if (!options) options = {};
    if (!credentials) credentials = {};
    options['format'] = 'text';

    this.client_ = new grpcWeb.GrpcWebClientBase(options);
    this.hostname_ = hostname.replace(/\/+$/, '');
    this.credentials_ = credentials;
    this.options_ = options;
  }

  methodDescriptorGetInterlockingSystemState = new grpcWeb.MethodDescriptor(
    '/interlocking_system.InterlockingSystem/GetInterlockingSystemState',
    grpcWeb.MethodType.UNARY,
    interlocking_system_pb.Nothing,
    interlocking_system_pb.InterlockingSystemStateMessage,
    (request: interlocking_system_pb.Nothing) => {
      return request.serializeBinary();
    },
    interlocking_system_pb.InterlockingSystemStateMessage.deserializeBinary
  );

  getInterlockingSystemState(
    request: interlocking_system_pb.Nothing,
    metadata: grpcWeb.Metadata | null): Promise<interlocking_system_pb.InterlockingSystemStateMessage>;

  getInterlockingSystemState(
    request: interlocking_system_pb.Nothing,
    metadata: grpcWeb.Metadata | null,
    callback: (err: grpcWeb.RpcError,
               response: interlocking_system_pb.InterlockingSystemStateMessage) => void): grpcWeb.ClientReadableStream<interlocking_system_pb.InterlockingSystemStateMessage>;

  getInterlockingSystemState(
    request: interlocking_system_pb.Nothing,
    metadata: grpcWeb.Metadata | null,
    callback?: (err: grpcWeb.RpcError,
               response: interlocking_system_pb.InterlockingSystemStateMessage) => void) {
    if (callback !== undefined) {
      return this.client_.rpcCall(
        this.hostname_ +
          '/interlocking_system.InterlockingSystem/GetInterlockingSystemState',
        request,
        metadata || {},
        this.methodDescriptorGetInterlockingSystemState,
        callback);
    }
    return this.client_.unaryCall(
    this.hostname_ +
      '/interlocking_system.InterlockingSystem/GetInterlockingSystemState',
    request,
    metadata || {},
    this.methodDescriptorGetInterlockingSystemState);
  }

  methodDescriptorSetInterlockingSystemState = new grpcWeb.MethodDescriptor(
    '/interlocking_system.InterlockingSystem/SetInterlockingSystemState',
    grpcWeb.MethodType.UNARY,
    interlocking_system_pb.InterlockingSystemStateMessage,
    interlocking_system_pb.SetInterlockingSystemStateResponse,
    (request: interlocking_system_pb.InterlockingSystemStateMessage) => {
      return request.serializeBinary();
    },
    interlocking_system_pb.SetInterlockingSystemStateResponse.deserializeBinary
  );

  setInterlockingSystemState(
    request: interlocking_system_pb.InterlockingSystemStateMessage,
    metadata: grpcWeb.Metadata | null): Promise<interlocking_system_pb.SetInterlockingSystemStateResponse>;

  setInterlockingSystemState(
    request: interlocking_system_pb.InterlockingSystemStateMessage,
    metadata: grpcWeb.Metadata | null,
    callback: (err: grpcWeb.RpcError,
               response: interlocking_system_pb.SetInterlockingSystemStateResponse) => void): grpcWeb.ClientReadableStream<interlocking_system_pb.SetInterlockingSystemStateResponse>;

  setInterlockingSystemState(
    request: interlocking_system_pb.InterlockingSystemStateMessage,
    metadata: grpcWeb.Metadata | null,
    callback?: (err: grpcWeb.RpcError,
               response: interlocking_system_pb.SetInterlockingSystemStateResponse) => void) {
    if (callback !== undefined) {
      return this.client_.rpcCall(
        this.hostname_ +
          '/interlocking_system.InterlockingSystem/SetInterlockingSystemState',
        request,
        metadata || {},
        this.methodDescriptorSetInterlockingSystemState,
        callback);
    }
    return this.client_.unaryCall(
    this.hostname_ +
      '/interlocking_system.InterlockingSystem/SetInterlockingSystemState',
    request,
    metadata || {},
    this.methodDescriptorSetInterlockingSystemState);
  }

  methodDescriptorSetBlock = new grpcWeb.MethodDescriptor(
    '/interlocking_system.InterlockingSystem/SetBlock',
    grpcWeb.MethodType.UNARY,
    interlocking_system_pb.InterlockingSystemCommand,
    interlocking_system_pb.Nothing,
    (request: interlocking_system_pb.InterlockingSystemCommand) => {
      return request.serializeBinary();
    },
    interlocking_system_pb.Nothing.deserializeBinary
  );

  setBlock(
    request: interlocking_system_pb.InterlockingSystemCommand,
    metadata: grpcWeb.Metadata | null): Promise<interlocking_system_pb.Nothing>;

  setBlock(
    request: interlocking_system_pb.InterlockingSystemCommand,
    metadata: grpcWeb.Metadata | null,
    callback: (err: grpcWeb.RpcError,
               response: interlocking_system_pb.Nothing) => void): grpcWeb.ClientReadableStream<interlocking_system_pb.Nothing>;

  setBlock(
    request: interlocking_system_pb.InterlockingSystemCommand,
    metadata: grpcWeb.Metadata | null,
    callback?: (err: grpcWeb.RpcError,
               response: interlocking_system_pb.Nothing) => void) {
    if (callback !== undefined) {
      return this.client_.rpcCall(
        this.hostname_ +
          '/interlocking_system.InterlockingSystem/SetBlock',
        request,
        metadata || {},
        this.methodDescriptorSetBlock,
        callback);
    }
    return this.client_.unaryCall(
    this.hostname_ +
      '/interlocking_system.InterlockingSystem/SetBlock',
    request,
    metadata || {},
    this.methodDescriptorSetBlock);
  }

  methodDescriptorUnsetBlock = new grpcWeb.MethodDescriptor(
    '/interlocking_system.InterlockingSystem/UnsetBlock',
    grpcWeb.MethodType.UNARY,
    interlocking_system_pb.InterlockingSystemCommand,
    interlocking_system_pb.Nothing,
    (request: interlocking_system_pb.InterlockingSystemCommand) => {
      return request.serializeBinary();
    },
    interlocking_system_pb.Nothing.deserializeBinary
  );

  unsetBlock(
    request: interlocking_system_pb.InterlockingSystemCommand,
    metadata: grpcWeb.Metadata | null): Promise<interlocking_system_pb.Nothing>;

  unsetBlock(
    request: interlocking_system_pb.InterlockingSystemCommand,
    metadata: grpcWeb.Metadata | null,
    callback: (err: grpcWeb.RpcError,
               response: interlocking_system_pb.Nothing) => void): grpcWeb.ClientReadableStream<interlocking_system_pb.Nothing>;

  unsetBlock(
    request: interlocking_system_pb.InterlockingSystemCommand,
    metadata: grpcWeb.Metadata | null,
    callback?: (err: grpcWeb.RpcError,
               response: interlocking_system_pb.Nothing) => void) {
    if (callback !== undefined) {
      return this.client_.rpcCall(
        this.hostname_ +
          '/interlocking_system.InterlockingSystem/UnsetBlock',
        request,
        metadata || {},
        this.methodDescriptorUnsetBlock,
        callback);
    }
    return this.client_.unaryCall(
    this.hostname_ +
      '/interlocking_system.InterlockingSystem/UnsetBlock',
    request,
    metadata || {},
    this.methodDescriptorUnsetBlock);
  }

  methodDescriptorInitiateDirectionHandover = new grpcWeb.MethodDescriptor(
    '/interlocking_system.InterlockingSystem/InitiateDirectionHandover',
    grpcWeb.MethodType.UNARY,
    interlocking_system_pb.InterlockingSystemCommand,
    interlocking_system_pb.Nothing,
    (request: interlocking_system_pb.InterlockingSystemCommand) => {
      return request.serializeBinary();
    },
    interlocking_system_pb.Nothing.deserializeBinary
  );

  initiateDirectionHandover(
    request: interlocking_system_pb.InterlockingSystemCommand,
    metadata: grpcWeb.Metadata | null): Promise<interlocking_system_pb.Nothing>;

  initiateDirectionHandover(
    request: interlocking_system_pb.InterlockingSystemCommand,
    metadata: grpcWeb.Metadata | null,
    callback: (err: grpcWeb.RpcError,
               response: interlocking_system_pb.Nothing) => void): grpcWeb.ClientReadableStream<interlocking_system_pb.Nothing>;

  initiateDirectionHandover(
    request: interlocking_system_pb.InterlockingSystemCommand,
    metadata: grpcWeb.Metadata | null,
    callback?: (err: grpcWeb.RpcError,
               response: interlocking_system_pb.Nothing) => void) {
    if (callback !== undefined) {
      return this.client_.rpcCall(
        this.hostname_ +
          '/interlocking_system.InterlockingSystem/InitiateDirectionHandover',
        request,
        metadata || {},
        this.methodDescriptorInitiateDirectionHandover,
        callback);
    }
    return this.client_.unaryCall(
    this.hostname_ +
      '/interlocking_system.InterlockingSystem/InitiateDirectionHandover',
    request,
    metadata || {},
    this.methodDescriptorInitiateDirectionHandover);
  }

}

