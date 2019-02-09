﻿#version 410
#extension GL_ARB_shading_language_420pack: enable

layout (location = 0) in vec4 Clr;
//layout (location = 1) in vec2 UV;
layout (location = 2) in vec3 ViewPosition;
layout (location = 3) in vec3 Pos;

layout (binding = 0) uniform sampler2D ColorTexture;
layout (binding = 1) uniform sampler2D PositionTexture;
layout (binding = 2) uniform sampler2D NormalTexture;

uniform vec2 Resolution;
uniform vec3 ViewPos;

uniform vec3 LightColor;
uniform vec3 LightPosition;
uniform float LightRadius;

layout (location = 0) out vec4 OutClr;

void main() {
	vec2 UV = gl_FragCoord.xy / Resolution;

	vec3 FragPos = texture(PositionTexture, UV).rgb;
	vec3 Normal = texture(NormalTexture, UV).rgb;
	vec3 Diffuse = texture(ColorTexture, UV).rgb;
	float Specular = 0.0f;

	vec3 SurfaceToLight = LightPosition - FragPos;
	float Brightness = smoothstep(LightRadius, 0, length(SurfaceToLight));

	OutClr = vec4(Diffuse * LightColor * Brightness, 1);
	//OutClr = vec4(clamp(Brightness, 0.2, 1.0) * LightColor, 1.0f);
}