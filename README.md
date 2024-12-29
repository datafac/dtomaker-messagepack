# DTOMaker

Source generators for various kinds of DTOs (Data Transport Objects) and
POCOs (Plain Old C# Objects).

[![Build-Deploy](https://github.com/datafac/dtomaker/actions/workflows/dotnet.yml/badge.svg)](https://github.com/datafac/dtomaker/actions/workflows/dotnet.yml)

*Warning: This is pre-release software under active development. Not for production use. Breaking changes occur often.*

## Source Generators
The following source generators are maintained in this repo:

### DTOMaker.MessagePack
Generates DTOs decorated with MessagePack attributes (https://github.com/MessagePack-CSharp/MessagePack-CSharp).

### DTOMaker.MemBlocks
Generates DTOs whose internal data is a single memory block (Memory\<byte\>). Property getters and setters decode and encode
values directly to the block with explicit byte ordering (little-endian or big-endian).

### DTOMaker.CSPoco
Generates basic POCOs (Plain Old C# Objects) that implement the data model interfaces.

## Features

### Member data types
- Value types: Boolean, S/Byte, U/Int16/32/64/128, Double, Single, Half, Char, Guid, Decimal
- Strings.
- Arrays of the above defined as ReadOnlyMemory\<T\>.
- Exceptions:
  - DTOMaker.MemBlocks members map to fixed size memory blocks. Thus string and array members require a
	[Length] attribute.

## Coming soon/later
- DTOMaker.JsonNewtonSoft
- DTOMaker.JsonSystemText
- DTOMaker.Records
- DTOMaker.NetStrux
