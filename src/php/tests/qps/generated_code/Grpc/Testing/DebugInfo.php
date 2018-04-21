<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: src/proto/grpc/testing/echo_messages.proto

namespace Grpc\Testing;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Message to be echoed back serialized in trailer.
 *
 * Generated from protobuf message <code>grpc.testing.DebugInfo</code>
 */
class DebugInfo extends \Google\Protobuf\Internal\Message
{
    /**
     * Generated from protobuf field <code>repeated string stack_entries = 1;</code>
     */
    private $stack_entries;
    /**
     * Generated from protobuf field <code>string detail = 2;</code>
     */
    private $detail = '';

    public function __construct() {
        \GPBMetadata\Src\Proto\Grpc\Testing\EchoMessages::initOnce();
        parent::__construct();
    }

    /**
     * Generated from protobuf field <code>repeated string stack_entries = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getStackEntries()
    {
        return $this->stack_entries;
    }

    /**
     * Generated from protobuf field <code>repeated string stack_entries = 1;</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setStackEntries($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->stack_entries = $arr;

        return $this;
    }

    /**
     * Generated from protobuf field <code>string detail = 2;</code>
     * @return string
     */
    public function getDetail()
    {
        return $this->detail;
    }

    /**
     * Generated from protobuf field <code>string detail = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setDetail($var)
    {
        GPBUtil::checkString($var, True);
        $this->detail = $var;

        return $this;
    }

}
