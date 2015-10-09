//uniform vec3 iMouse;
uniform vec2 iResolution;
uniform float iGlobalTime;
in vec2 uv;
		
void mainImage( out vec4 fragColor, in vec2 fragCoord )
{
	vec2 uv = mod(uv * 10.0, 1.0);
	float a = length(uv - vec2(0.5));
	a = pow(1.0 - a, 12);
//	a = mod(a, 10.0);
	fragColor = vec4(a, a, a, 1.0);
}

void main()
{
	mainImage(gl_FragColor, gl_FragCoord.xy);
}
