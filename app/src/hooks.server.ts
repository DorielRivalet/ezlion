import type { Handle } from '@sveltejs/kit';
import { RateLimiter } from 'sveltekit-rate-limiter/server';
import { building } from '$app/environment';

const limiter = new RateLimiter({
	IP: [30, 'm'],
	IPUA: [30, 'm']
});

export const handle: Handle = async ({ event, resolve }) => {
	if (building) {
		const response = await resolve(event);
		return response;
	}

	if (await limiter.isLimited(event)) {
		return new Response('Too Many Requests', { status: 429 });
	}

	const response = await resolve(event);
	return response;
};
