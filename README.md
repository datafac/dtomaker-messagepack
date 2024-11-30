# DTOMaker

Source generators for various kinds of DTOs and POCOs.

[![Build-Deploy](https://github.com/datafac/dtomaker/actions/workflows/dotnet.yml/badge.svg)](https://github.com/datafac/dtomaker/actions/workflows/dotnet.yml)

*Warning: This is pre-release software under active development. Not for production use. Breaking changes occur often.*

The following source generators are maintained in this repo:

## DTOMaker.MessagePack
Generates DTOs decorated with MessagePack attributes (https://github.com/MessagePack-CSharp/MessagePack-CSharp).

## DTOMaker.MemBlocks
Generates DTOs whose internal data is a single memory block (Memory\<byte\>). Property getters and setters decode and encode
values directly to the block with explicit byte ordering (little-endian or big-endian).

## DTOMaker.CSPoco
Generates basic POCOs (Plain Old C# Objects) that implement the data model interfaces.

## Coming soon/later
- DTOMaker.JsonNewtonSoft
- DTOMaker.JsonSystemText
- DTOMaker.Records
- DTOMaker.NetStrux
