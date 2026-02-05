/**
 * Fragment shader for WBOIT accumulation pass (square points)
 *
 * Outputs pre-multiplied colors: vec4(R*a, G*a, B*a, a)
 * where a = color.a
 *
 * This allows additive blending to accumulate colors properly
 * for later normalization by dividing by total alpha.
 */
const FRAGMENT_SHADER = `precision highp float;

varying vec4 color;

void main() {
  // Pre-multiply color by alpha for WBOIT accumulation
  gl_FragColor = vec4(color.rgb * color.a, color.a);
}
`;

export default FRAGMENT_SHADER;
