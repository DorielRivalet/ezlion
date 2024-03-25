<script lang="ts">
	import { page } from '$app/stores';
	import Logo from '$lib/components/Logo.svelte';
	import image from '$lib/assets/ezlion.png';
	import { authorName, description, projectGitHub, projectName, website } from '$lib/constants';
	import Footer from './Footer.svelte';
	import SectionHeadingTopLevel from '$lib/components/SectionHeadingTopLevel.svelte';
	import SectionHeading from '$lib/components/SectionHeading.svelte';
	import Link from 'carbon-components-svelte/src/Link/Link.svelte';
	import OutboundLink from 'carbon-components-svelte/src/Link/OutboundLink.svelte';
	import CodeSnippet from 'carbon-components-svelte/src/CodeSnippet/CodeSnippet.svelte';
	import RepositoryThumbnail from '$lib/assets/ezlion.png';
	import './styles.css';
	import { codeToHtml } from 'shiki';
	import { browser } from '$app/environment';
	import { onMount } from 'svelte';

	const title = 'Home';
	const url = $page.url.toString();

	let isShikiLoading = true;

	async function renderShiki(inputs: string, language: string) {
		if (!browser) return '';
		if (language === 'json') {
			//inputs = JSON.stringify(inputs);
		}
		const result = await codeToHtml(inputs, {
			lang: language,
			theme:
				document.documentElement.getAttribute('theme') === 'g100'
					? 'catppuccin-mocha'
					: 'catppuccin-latte'
		});
		return result;
	}

	let example1Request = `curl https://yourprojectname.vercel.app/api/v0/monsters/1`;
	let example1Response = `{ id: 1, name: 'Rathian' }`;
	let example2Request = `curl https://yourprojectname.vercel.app/api/v0/monsters`;
	let example2Response = `{
  results: [
    { id: 0, name: 'None' },
    { id: 1, name: 'Rathian' },
    { id: 2, name: 'Rathalos' }
  ],
  metadata: {
    readonly: true,
    repository: 'https://github.com/DorielRivalet/ezlion'
  }
}`;
	let example1RequestShiki: string;
	let example1ResponseShiki: string;
	let example2RequestShiki: string;
	let example2ResponseShiki: string;

	onMount(async () => {
		example1RequestShiki = await renderShiki(example1Request, 'bash');
		example1ResponseShiki = await renderShiki(example1Response, 'json');
		example2RequestShiki = await renderShiki(example2Request, 'bash');
		example2ResponseShiki = await renderShiki(example2Response, 'json');

		isShikiLoading = false;
	});
</script>

<svelte:head>
	<link rel="canonical" href={url} />

	<!-- HTML Meta Tags -->
	<title>{title}</title>
	<meta name="title" content={title} />
	<meta name="description" content={description} />

	{#if authorName}
		<meta name="author" content={authorName} />
	{/if}

	<!-- Google / Search Engine Tags -->
	{#if image}
		<meta itemprop="name" content={title} />
		<meta itemprop="description" content={description} />
		<meta itemprop="image" content={image} />
	{/if}

	<!-- Facebook Meta Tags -->
	{#if image}
		<meta property="og:url" content={url} />
		<meta property="og:type" content="website" />
		<meta property="og:title" content={title} />
		<meta property="og:description" content={description} />
		<meta property="og:image" content={image} />
		<meta property="og:image:alt" content="Elzelion wearing sunglasses" />
		<meta property="og:site_name" content={projectName} />
	{/if}

	<!-- Discord-->
	<meta content="#89b4fa" data-react-helmet="true" name="theme-color" />

	<!-- Twitter Meta Tags -->
	{#if image}
		<meta name="twitter:card" content="summary_large_image" />
		{#if website}
			<meta property="twitter:domain" content={website} />
		{/if}
		<meta property="twitter:url" content={url} />
		<meta name="twitter:title" content={title} />
		<meta name="twitter:description" content={description} />
		<meta name="twitter:image" content={image} />
	{/if}
</svelte:head>

<div class="app">
	<main>
		<SectionHeadingTopLevel title={'EZlion'} />
		<Logo />
		<p class="slogan">Data retrieval, made easy</p>
		<section>
			<SectionHeading level={2} title={'About'} withSeparator={true} />
			<p>A data retrieval and translation project for Monster Hunter Frontier Z.</p>
		</section>
		<section class="api-reference">
			<SectionHeading level={2} title={'API Reference'} withSeparator={true} />
			<p>See <Link data-sveltekit-reload href="./docs">here</Link> for the API reference.</p>
			<p>It is recommended to host the API yourself. You can do so by doing the following:</p>

			<ol>
				<li>
					1. Fork the <OutboundLink href="https://github.com/DorielRivalet/ezlion/fork"
						>repository</OutboundLink
					>.
				</li>
				<li>
					2. Deploy the project following the instructions <OutboundLink
						href="https://vercel.com/docs/deployments/git#deploying-a-git-repository"
						>here</OutboundLink
					>. Select app/ as the root of the project in Vercel Settings.
				</li>
				<li>
					3. Confirm if it worked correctly by checking the API Reference at
					<CodeSnippet type={'inline'} showMoreLess={false} hideCopyButton
						>https://yourprojectname.vercel.app/docs</CodeSnippet
					>.
				</li>
			</ol>

			<section class="usage">
				<SectionHeading level={3} title={'Usage'} withSeparator={true} />

				<p>
					The API is static, you can only use the <strong>GET</strong> HTTP method.
				</p>
				<p>We provide the following data, as an example:</p>

				<div class="examples">
					<div class="example">
						<p><strong>Request: </strong> Get monster by id</p>

						<div class="container-shiki">
							{#if isShikiLoading}
								<div style="min-width: 32rem;">
									<CodeSnippet type="multi" skeleton />
								</div>
							{:else}
								<CodeSnippet showMoreLess={false} hideCopyButton type="multi"
									>{@html example1RequestShiki}</CodeSnippet
								>
							{/if}
						</div>
					</div>
					<div class="example">
						<p><strong>Response:</strong></p>

						<div class="container-shiki">
							{#if isShikiLoading}
								<div style="min-width: 32rem;">
									<CodeSnippet type="multi" skeleton />
								</div>
							{:else}
								<CodeSnippet showMoreLess={false} hideCopyButton type="multi"
									>{@html example1ResponseShiki}</CodeSnippet
								>
							{/if}
						</div>
					</div>
					<div class="example">
						<p><strong>Request: </strong>Get monsters</p>

						<div class="container-shiki">
							{#if isShikiLoading}
								<div style="min-width: 32rem; ">
									<CodeSnippet type="multi" skeleton />
								</div>
							{:else}
								<CodeSnippet showMoreLess={false} hideCopyButton type="multi"
									>{@html example2RequestShiki}</CodeSnippet
								>
							{/if}
						</div>
					</div>
					<div class="example">
						<p><strong>Response:</strong></p>

						<div class="container-shiki">
							{#if isShikiLoading}
								<div style="min-width: 32rem; ">
									<CodeSnippet type="multi" skeleton />
								</div>
							{:else}
								<CodeSnippet showMoreLess={false} hideCopyButton type="multi"
									>{@html example2ResponseShiki}</CodeSnippet
								>
							{/if}
						</div>
					</div>
				</div>
			</section>
			<div class="more-info">
				<p>
					For more information, consult the documentation <OutboundLink
						href="https://github.com/DorielRivalet/ezlion/tree/main/docs#API">here</OutboundLink
					>.
				</p>
				<Link aria-label="GitHub repository" href={projectGitHub}>
					<img title="Go to repository" src={RepositoryThumbnail} alt="Repository thumbnail" />
				</Link>
			</div>
		</section>
	</main>

	<Footer />
</div>

<style type="text/css">
	.more-info {
		margin-top: 2rem;
		display: flex;
		flex-direction: column;
		gap: 1rem;
	}

	.examples {
		display: flex;
		flex-direction: column;
		gap: 2rem;
		margin-top: 1rem;
	}

	.example {
		display: flex;
		flex-direction: column;
		gap: 1rem;
	}

	.slogan {
		font-style: italic;
	}

	.app {
		display: flex;
		flex-direction: column;
		background-color: var(--ctp-mantle);
	}

	main {
		position: relative;
		flex: 1;
		display: flex;
		flex-direction: column;
		padding: var(--cds-spacing-08);
		width: 100%;
		max-width: 100vw;
		margin: 0 auto;
		box-sizing: border-box;
		min-height: 90vh;
		background-color: var(--ctp-base);
		border-left: var(--cds-spacing-01) solid var(--ctp-surface0);
		border-right: var(--cds-spacing-01) solid var(--ctp-surface0);
		border-bottom: var(--cds-spacing-01) solid var(--ctp-surface0);
		border-radius: 0px 0px 10px 10px;
	}
</style>
